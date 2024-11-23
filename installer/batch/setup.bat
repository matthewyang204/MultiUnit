@echo off
REM Check for administrator privileges
net session >nul 2>&1
if %errorlevel% neq 0 (
    echo Please run this script as Administrator.
    pause
    exit /b
)

REM Set the source path and destination directory
set "SOURCE=%~dp0"
set "TARGET=%ProgramFiles%\MultiUnit"

REM Ensure the target directory exists
if not exist "%TARGET%" (
    mkdir "%TARGET%"
)

REM Copy MultiUnit.exe from the mounted ISO to the target directory
echo Copying MultiUnit.exe to %TARGET%...
copy "%SOURCE%\MultiUnit.exe" "%TARGET%" /y
if %errorlevel% neq 0 (
    echo Failed to copy MultiUnit.exe. Ensure it exists in the ISO folder.
    pause
    exit /b
)

REM Determine Start Menu directory based on OS
set "SHORTCUT_DIR=%ProgramData%\Microsoft\Windows\Start Menu\Programs"
if not exist "%SHORTCUT_DIR%" (
    echo %ProgramData% not found. Assuming Windows XP or similar.
    set "SHORTCUT_DIR=%ALLUSERSPROFILE%\Start Menu\Programs"
    if not exist "%SHORTCUT_DIR%" (
        echo %ALLUSERSPROFILE% not found. Falling back to current user.
        set "SHORTCUT_DIR=%USERPROFILE%\Start Menu\Programs"
    )
)

REM Create the Start Menu shortcut
set "SHORTCUT=%SHORTCUT_DIR%\MultiUnit.lnk"

echo Creating Start Menu shortcut at %SHORTCUT%...
if not exist "%SHORTCUT_DIR%" (
    mkdir "%SHORTCUT_DIR%"
)
echo [InternetShortcut] > "%SHORTCUT%"
echo URL=file:///%TARGET%\MultiUnit.exe >> "%SHORTCUT%"
if exist "%SHORTCUT%" (
    echo Shortcut created successfully at %SHORTCUT%.
) else (
    echo Failed to create Start Menu shortcut.
    pause
    exit /b
)

REM Run dotnetfx35.exe
echo Running dotnetfx35.exe...
"%SOURCE%\dotnetfx35.exe"
if %errorlevel% neq 0 (
    echo dotnetfx35.exe failed to run. Ensure it exists in the script folder.
    pause
    exit /b
)

echo Setup completed successfully!
pause
