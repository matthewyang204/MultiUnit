#!/bin/bash
set -euo pipefail

if command -v port >/dev/null 2>&1; then
    PATH=$PWD/shims/macports:$PATH
fi

ROOT="$(cd "$(dirname "$0")" && pwd)"
OUTPUT="${1:-$ROOT/dist/macos/MultiUnit.app}"
if [ -e "$OUTPUT" ]; then
    echo "Output already exists: $OUTPUT" >&2
    exit 1
fi

case "$(uname -m)" in
    arm64) RID="osx-arm64" ;;
    x86_64) RID="osx-x64" ;;
    *) echo "Unsupported macOS architecture: $(uname -m)" >&2; exit 1 ;;
esac

command -v pkg-config >/dev/null || { echo "pkg-config is required" >&2; exit 1; }
pkg-config --exists gtk+-3.0 || { echo "GTK+ 3 development files are required (install gtk+3 with Homebrew)" >&2; exit 1; }
command -v brew >/dev/null || { echo "Homebrew is required to resolve and validate GTK dependencies" >&2; exit 1; }

# Homebrew's rolling bottles can target a newer macOS release than this app's
# deployment target. Reject those libraries rather than emitting a bundle that
# appears complete but fails on older clean installations at dyld load time.
APP_MIN_MACOS="${MACOSX_DEPLOYMENT_TARGET:-$(sw_vers -productVersion)}"
version_at_least() {
    awk -v actual="$1" -v minimum="$2" 'BEGIN {
        split(actual, a, "."); split(minimum, b, ".");
        for (i = 1; i <= 3; i++) {
            av = a[i] + 0; bv = b[i] + 0;
            if (av > bv) exit 0;
            if (av < bv) exit 1;
        }
        exit 0;
    }'
}

STAGE="$(mktemp -d "${TMPDIR:-/tmp}/multiunit-macos.XXXXXX")"
trap 'rm -rf "$STAGE"' EXIT
APP="$STAGE/MultiUnit.app"
CONTENTS="$APP/Contents"
MACOS="$CONTENTS/MacOS"
FRAMEWORKS="$CONTENTS/Frameworks"
GTKROOT="$CONTENTS/Resources/gtk"
PUBLISH="$STAGE/publish"
mkdir -p "$MACOS" "$FRAMEWORKS" "$GTKROOT"

dotnet publish "$ROOT/MultiUnit.vbproj" -c Release -r "$RID" --self-contained true \
    -p:UseAppHost=true -p:PublishSingleFile=false -o "$PUBLISH"
cp -R "$PUBLISH"/. "$MACOS"/
mv "$MACOS/MultiUnit" "$MACOS/MultiUnit.native"

GTK_PREFIX="$(pkg-config --variable=prefix gtk+-3.0)"
GTK_LIBDIR="$(pkg-config --variable=libdir gtk+-3.0)"
PIXBUF_PREFIX="$(pkg-config --variable=prefix gdk-pixbuf-2.0)"
PIXBUF_LIBDIR="$(pkg-config --variable=libdir gdk-pixbuf-2.0)"
GLIB_PREFIX="$(pkg-config --variable=prefix glib-2.0)"
PIXBUF_BINDIR="$(pkg-config --variable=bindir gdk-pixbuf-2.0)"
BREW_PREFIX="$(brew --prefix)"
SEEN="$STAGE/native-files.txt"
QUEUE="$STAGE/native-queue.txt"
: > "$SEEN"
printf '%s\n' "$GTK_LIBDIR/libgtk-3.0.dylib" "$PIXBUF_BINDIR/gdk-pixbuf-query-loaders" >> "$QUEUE"
if [ -x "$GTK_PREFIX/bin/gtk-query-immodules-3.0" ]; then
    printf '%s\n' "$GTK_PREFIX/bin/gtk-query-immodules-3.0" >> "$QUEUE"
fi
for dir in "$GTK_LIBDIR/gtk-3.0" "$PIXBUF_LIBDIR/gdk-pixbuf-2.0"; do
    if [ -d "$dir" ]; then
        find -L "$dir" -type f \( -name '*.dylib' -o -name '*.so' \) -print >> "$QUEUE"
    fi
done

while [ -s "$QUEUE" ]; do
    SOURCE="$(head -n 1 "$QUEUE")"
    tail -n +2 "$QUEUE" > "$QUEUE.next"
    mv "$QUEUE.next" "$QUEUE"
    [ -f "$SOURCE" ] || continue
    SOURCE="$(cd "$(dirname "$SOURCE")" && pwd -P)/$(basename "$SOURCE")"
    grep -Fxq "$SOURCE" "$SEEN" && continue
    printf '%s\n' "$SOURCE" >> "$SEEN"
    MIN_OS="$(otool -l "$SOURCE" | awk '
        /LC_BUILD_VERSION/ { build=1; next }
        build && /minos/ { print $2; exit }
        /LC_VERSION_MIN_MACOSX/ { legacy=1; next }
        legacy && /version/ { print $2; exit }
    ')"
    if [ -n "$MIN_OS" ] && ! version_at_least "$APP_MIN_MACOS" "$MIN_OS"; then
        echo "Incompatible GTK dependency: $SOURCE requires macOS $MIN_OS; app target is $APP_MIN_MACOS." >&2
        echo "Install GTK dependencies built for macOS $APP_MIN_MACOS or newer, or raise MACOSX_DEPLOYMENT_TARGET." >&2
        exit 1
    fi
    install -m 755 "$SOURCE" "$FRAMEWORKS/$(basename "$SOURCE")"
    otool -L "$SOURCE" | sed -n '2,$s/^[[:space:]]*\([^ ]*\).*/\1/p' | while IFS= read -r DEP; do
        case "$DEP" in
            /System/Library/*|/usr/lib/*) ;;
            /*) [ -f "$DEP" ] && printf '%s\n' "$DEP" >> "$QUEUE" ;;
            @rpath/*)
                DEPBASE="${DEP##*/}"
                CANDIDATE="$(dirname "$SOURCE")/$DEPBASE"
                if [ -f "$CANDIDATE" ]; then
                    printf '%s\n' "$CANDIDATE" >> "$QUEUE"
                else
                    find -L "$BREW_PREFIX" -type f -name "$DEPBASE" -print -quit 2>/dev/null >> "$QUEUE"
                fi
                ;;
            @loader_path/*|@executable_path/*)
                RELATIVE="${DEP#*/}"
                CANDIDATE="$(dirname "$SOURCE")/$RELATIVE"
                [ -f "$CANDIDATE" ] && printf '%s\n' "$CANDIDATE" >> "$QUEUE"
                ;;
        esac
    done
done

while IFS= read -r SOURCE; do
    TARGET="$FRAMEWORKS/$(basename "$SOURCE")"
    ID_LINES="$(otool -D "$SOURCE" 2>/dev/null | wc -l | tr -d ' ')"
    if [ "$ID_LINES" -gt 1 ]; then
        install_name_tool -id "@rpath/$(basename "$SOURCE")" "$TARGET" 2>/dev/null
    fi
    otool -L "$SOURCE" | sed -n '2,$s/^[[:space:]]*\([^ ]*\).*/\1/p' | while IFS= read -r DEP; do
        case "$DEP" in
            /System/Library/*|/usr/lib/*) ;;
            /*|@rpath/*|@loader_path/*)
                DEPBASE="$(basename "$DEP")"
                if [ -f "$FRAMEWORKS/$DEPBASE" ]; then
                    install_name_tool -change "$DEP" "@rpath/$DEPBASE" "$TARGET" 2>/dev/null
                fi
                ;;
            @executable_path/*)
                DEPBASE="$(basename "$DEP")"
                if [ -f "$FRAMEWORKS/$DEPBASE" ]; then
                    install_name_tool -change "$DEP" "@rpath/$DEPBASE" "$TARGET" 2>/dev/null
                fi
                ;;
        esac
    done
    install_name_tool -add_rpath @loader_path "$TARGET" 2>/dev/null || true
    install_name_tool -add_rpath @executable_path/../Frameworks "$TARGET" 2>/dev/null || true
done < "$SEEN"

copy_tree() {
    SOURCE_DIR="$1"
    TARGET_DIR="$2"
    if [ -d "$SOURCE_DIR" ]; then
        mkdir -p "$(dirname "$TARGET_DIR")"
        cp -R -L "$SOURCE_DIR" "$TARGET_DIR"
    fi
}
copy_tree "$GTK_PREFIX/share/gtk-3.0" "$GTKROOT/share/gtk-3.0"
copy_tree "$GLIB_PREFIX/share/glib-2.0/schemas" "$GTKROOT/share/glib-2.0/schemas"
copy_tree "$GTK_PREFIX/share/icons" "$GTKROOT/share/icons"
copy_tree "$GTK_PREFIX/share/themes" "$GTKROOT/share/themes"
if [ -d "$GTK_LIBDIR/gtk-3.0" ]; then
    mkdir -p "$GTKROOT/lib"
    cp -R -L "$GTK_LIBDIR/gtk-3.0" "$GTKROOT/lib/"
fi
if [ -d "$PIXBUF_LIBDIR/gdk-pixbuf-2.0" ]; then
    mkdir -p "$GTKROOT/lib"
    cp -R -L "$PIXBUF_LIBDIR/gdk-pixbuf-2.0" "$GTKROOT/lib/"
fi
chmod -R u+w "$GTKROOT/lib"
mkdir -p "$GTKROOT/bin"
mkdir -p "$GTKROOT/etc/gtk-3.0"
if [ -d "$GTK_PREFIX/etc/fonts" ]; then cp -R "$GTK_PREFIX/etc/fonts" "$GTKROOT/etc/"; fi
if [ -d "$GTK_PREFIX/etc/gtk-3.0" ]; then cp -R "$GTK_PREFIX/etc/gtk-3.0"/. "$GTKROOT/etc/gtk-3.0/"; fi
while IFS= read -r SOURCE; do
    case "$SOURCE" in
        "$GTK_LIBDIR"/gtk-3.0/*)
            REL="${SOURCE#"$GTK_LIBDIR"/}"
            mkdir -p "$GTKROOT/lib/$(dirname "$REL")"
            cp "$FRAMEWORKS/$(basename "$SOURCE")" "$GTKROOT/lib/$REL"
            ;;
        "$PIXBUF_LIBDIR"/gdk-pixbuf-2.0/*)
            REL="${SOURCE#"$PIXBUF_LIBDIR"/}"
            mkdir -p "$GTKROOT/lib/$(dirname "$REL")"
            cp "$FRAMEWORKS/$(basename "$SOURCE")" "$GTKROOT/lib/$REL"
            ;;
    esac
done < "$SEEN"

cat > "$MACOS/MultiUnit" <<'LAUNCHER'
#!/bin/bash
HERE="$(cd "$(dirname "$0")" && pwd)"
CONTENTS="$(cd "$HERE/.." && pwd)"
GTKROOT="$CONTENTS/Resources/gtk"
export DYLD_LIBRARY_PATH="$CONTENTS/Frameworks${DYLD_LIBRARY_PATH:+:$DYLD_LIBRARY_PATH}"
export GTK_DATA_PREFIX="$GTKROOT"
export GTK_EXE_PREFIX="$GTKROOT"
export GTK_PATH="$GTKROOT/lib/gtk-3.0"
export GSETTINGS_SCHEMA_DIR="$GTKROOT/share/glib-2.0/schemas"
export XDG_DATA_DIRS="$GTKROOT/share${XDG_DATA_DIRS:+:$XDG_DATA_DIRS}"
RUNTIME_CACHE="${TMPDIR:-/tmp}/multiunit-gtk-${UID:-user}"
mkdir -p "$RUNTIME_CACHE"
export GDK_PIXBUF_MODULE_FILE="$RUNTIME_CACHE/gdk-pixbuf.loaders"
export GTK_IM_MODULE_FILE="$RUNTIME_CACHE/gtk.immodules"
PIXBUF_LOADERS="$GTKROOT/lib/gdk-pixbuf-2.0/2.10.0/loaders"
if [ -x "$CONTENTS/Frameworks/gdk-pixbuf-query-loaders" ] && [ -d "$PIXBUF_LOADERS" ]; then
    "$CONTENTS/Frameworks/gdk-pixbuf-query-loaders" "$PIXBUF_LOADERS"/*.so > "$GDK_PIXBUF_MODULE_FILE" || exit 1
fi
if [ -x "$CONTENTS/Frameworks/gtk-query-immodules-3.0" ] && [ -d "$GTKROOT/lib/gtk-3.0/3.0.0/immodules" ]; then
    "$CONTENTS/Frameworks/gtk-query-immodules-3.0" "$GTKROOT"/lib/gtk-3.0/3.0.0/immodules/*.so > "$GTK_IM_MODULE_FILE" || exit 1
fi
exec "$HERE/MultiUnit.native" "$@"
LAUNCHER
chmod +x "$MACOS/MultiUnit"

cat > "$CONTENTS/Info.plist" <<PLIST
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0"><dict>
<key>CFBundleExecutable</key><string>MultiUnit</string>
<key>CFBundleIdentifier</key><string>org.multiunit.app</string>
<key>CFBundleName</key><string>MultiUnit</string>
<key>CFBundlePackageType</key><string>APPL</string>
<key>CFBundleVersion</key><string>1.0.0</string>
<key>LSMinimumSystemVersion</key><string>$APP_MIN_MACOS</string>
</dict></plist>
PLIST

mkdir -p "$(dirname "$OUTPUT")"
install_name_tool -add_rpath @executable_path/../Frameworks "$MACOS/MultiUnit.native" 2>/dev/null || true
if command -v codesign >/dev/null; then codesign --force --deep --sign - "$APP"; fi
mv "$APP" "$OUTPUT"
echo "Created $OUTPUT"
