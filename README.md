# MultiUnit
 A simple unit converter written in Visual Basic. This app has a pretty self-explanatory GUI. Additionally, this app has a portable version that doesn't need to be installed alongside the ordinary installable version. You can get the source code from the branch called dotnet2.0, which implements all features but uses .NET 2.0 to build and run, which allows it to run on Windows XP and Vista.

# System Requirements
- Windows 7 or later

# Installing

1. Download the installer or build it (see next section)
2. Run the installer, and select whether you want to install it to your system's Program Files or just for your user.

# Building
1. Install a version of Microsoft Visual Studio that supports .NET 4.0.
2. Open up the solution within src\MultiUnit. From the menu bar, hit Build > Build MultiUnit.
3. Now, install Inno Setup if you haven't. Then, compile the installer from the installer folder.

# Building on non-Windows platforms
On macOS, you can use the free tier of JetBrains Rider. You can use Inno Setup running in Wine to package the installer.
