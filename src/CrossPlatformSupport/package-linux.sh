#!/bin/bash
set -euo pipefail

ROOT="$(cd "$(dirname "$0")" && pwd)"
OUTPUT="${1:-$ROOT/dist/linux}"
RID="${2:-}"
if [ -e "$OUTPUT" ]; then
    echo "Output already exists: $OUTPUT" >&2
    exit 1
fi
if [ "$(uname -s)" != "Linux" ]; then
    echo "Run this script on the Linux machine or build container matching the target platform" >&2
    exit 1
fi
command -v pkg-config >/dev/null || { echo "pkg-config is required" >&2; exit 1; }
pkg-config --exists gtk+-3.0 || { echo "GTK+ 3 development files are required" >&2; exit 1; }

if [ -z "$RID" ]; then
    case "$(uname -m)" in
        x86_64) RID=linux-x64 ;;
        aarch64|arm64) RID=linux-arm64 ;;
        *) echo "Unsupported Linux architecture: $(uname -m)" >&2; exit 1 ;;
    esac
fi

STAGE="$(mktemp -d "${TMPDIR:-/tmp}/multiunit-linux.XXXXXX")"
trap 'rm -rf "$STAGE"' EXIT
APP="$STAGE/app"
GTKROOT="$APP/gtk"
PUBLISH="$STAGE/publish"
mkdir -p "$APP/app" "$APP/lib" "$APP/bin" "$GTKROOT"

dotnet publish "$ROOT/MultiUnit.vbproj" -c Release -r "$RID" --self-contained true \
    -p:UseAppHost=true -p:PublishSingleFile=false -o "$PUBLISH"
cp -R "$PUBLISH"/. "$APP/app/"

GTK_PREFIX="$(pkg-config --variable=prefix gtk+-3.0)"
GTK_LIBDIR="$(pkg-config --variable=libdir gtk+-3.0)"
PIXBUF_LIBDIR="$(pkg-config --variable=libdir gdk-pixbuf-2.0)"
GLIB_PREFIX="$(pkg-config --variable=prefix glib-2.0)"
PIXBUF_BINDIR="$(pkg-config --variable=bindir gdk-pixbuf-2.0)"
SEEN="$STAGE/native-files.txt"
QUEUE="$STAGE/native-queue.txt"
: > "$SEEN"
printf '%s\n' "$GTK_LIBDIR/libgtk-3.so.0" "$PIXBUF_LIBDIR/gdk-pixbuf-query-loaders" >> "$QUEUE"
if [ -x "$GTK_PREFIX/bin/gtk-query-immodules-3.0" ]; then
    printf '%s\n' "$GTK_PREFIX/bin/gtk-query-immodules-3.0" >> "$QUEUE"
fi
for dir in "$GTK_LIBDIR/gtk-3.0" "$PIXBUF_LIBDIR/gdk-pixbuf-2.0"; do
    if [ -d "$dir" ]; then
        find -L "$dir" -type f -name '*.so*' -print >> "$QUEUE"
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
    BASE="$(basename "$SOURCE")"
    case "$BASE" in
        libc.so*|libm.so*|libpthread.so*|libdl.so*|librt.so*|libresolv.so*|libutil.so*|ld-linux*.so*) continue ;;
    esac
    install -m 755 "$SOURCE" "$APP/lib/$BASE"
    ldd "$SOURCE" 2>/dev/null | awk '/=> \/|^[[:space:]]*\// { for (i=1; i<=NF; i++) if ($i ~ /^\//) { print $i; break } }' | while IFS= read -r DEP; do
        case "$(basename "$DEP")" in
            libc.so*|libm.so*|libpthread.so*|libdl.so*|librt.so*|libresolv.so*|libutil.so*|ld-linux*.so*) ;;
            *) [ -f "$DEP" ] && printf '%s\n' "$DEP" >> "$QUEUE" ;;
        esac
    done
done

for DATA in "$GTK_PREFIX/share/gtk-3.0" "$GTK_PREFIX/share/icons" "$GTK_PREFIX/share/themes"; do
    if [ -d "$DATA" ]; then
        mkdir -p "$GTKROOT/share"
        cp -R -L "$DATA" "$GTKROOT/share/"
    fi
done
if [ -d "$GLIB_PREFIX/share/glib-2.0/schemas" ]; then
    mkdir -p "$GTKROOT/share/glib-2.0"
    cp -R -L "$GLIB_PREFIX/share/glib-2.0/schemas" "$GTKROOT/share/glib-2.0/"
fi
if [ -d "$GTK_LIBDIR/gtk-3.0" ]; then
    mkdir -p "$GTKROOT/lib"
    cp -R -L "$GTK_LIBDIR/gtk-3.0" "$GTKROOT/lib/"
fi
if [ -d "$PIXBUF_LIBDIR/gdk-pixbuf-2.0" ]; then
    mkdir -p "$GTKROOT/lib"
    cp -R -L "$PIXBUF_LIBDIR/gdk-pixbuf-2.0" "$GTKROOT/lib/"
fi
chmod -R u+w "$GTKROOT/lib"
if [ -d /etc/gtk-3.0 ]; then cp -R /etc/gtk-3.0 "$GTKROOT/etc/"; fi
mkdir -p "$GTKROOT/bin" "$GTKROOT/etc/gtk-3.0"
cp "$PIXBUF_LIBDIR/gdk-pixbuf-2.0/gdk-pixbuf-query-loaders" "$GTKROOT/bin/"
if [ -x "$GTK_PREFIX/bin/gtk-query-immodules-3.0" ]; then
    cp "$GTK_PREFIX/bin/gtk-query-immodules-3.0" "$GTKROOT/bin/"
fi
while IFS= read -r SOURCE; do
    case "$SOURCE" in
        "$GTK_LIBDIR"/gtk-3.0/*)
            REL="${SOURCE#"$GTK_LIBDIR"/}"
            mkdir -p "$GTKROOT/lib/$(dirname "$REL")"
            cp "$APP/lib/$(basename "$SOURCE")" "$GTKROOT/lib/$REL"
            ;;
        "$PIXBUF_LIBDIR"/gdk-pixbuf-2.0/*)
            REL="${SOURCE#"$PIXBUF_LIBDIR"/}"
            mkdir -p "$GTKROOT/lib/$(dirname "$REL")"
            cp "$APP/lib/$(basename "$SOURCE")" "$GTKROOT/lib/$REL"
            ;;
    esac
done < "$SEEN"

cat > "$APP/MultiUnit" <<'LAUNCHER'
#!/bin/sh
APPDIR="$(CDPATH= cd -- "$(dirname -- "$0")" && pwd)"
GTKROOT="$APPDIR/gtk"
export LD_LIBRARY_PATH="$APPDIR/lib:$GTKROOT/lib/gtk-3.0/modules:$GTKROOT/lib/gdk-pixbuf-2.0/2.10.0/loaders${LD_LIBRARY_PATH:+:$LD_LIBRARY_PATH}"
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
if [ -x "$GTKROOT/bin/gdk-pixbuf-query-loaders" ] && [ -d "$PIXBUF_LOADERS" ]; then
    "$GTKROOT/bin/gdk-pixbuf-query-loaders" "$PIXBUF_LOADERS"/*.so > "$GDK_PIXBUF_MODULE_FILE"
fi
IMMODULES="$GTKROOT/lib/gtk-3.0/3.0.0/immodules"
if [ -x "$GTKROOT/bin/gtk-query-immodules-3.0" ] && [ -d "$IMMODULES" ]; then
    "$GTKROOT/bin/gtk-query-immodules-3.0" "$IMMODULES"/*.so > "$GTK_IM_MODULE_FILE"
fi
exec "$APPDIR/app/MultiUnit" "$@"
LAUNCHER
chmod +x "$APP/MultiUnit"

mkdir -p "$(dirname "$OUTPUT")"
mv "$APP" "$OUTPUT"
echo "Created $OUTPUT"
