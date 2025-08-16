# MultiUnit
 A simple unit converter written in Visual Basic

 This app has a pretty self-explanatory GUI.

# System Requirements
- Windows XP or later

# Installing
1. Download the installer or build it (see next section)
2. Run the installer as admin. While the main installer installs, if the .NET 3.5 installer pops up, walk through it.

# Building
1. Install Microsoft Visual Studio 2005 if you haven't. I have an [Internet Archive](https://archive.org/details/msdn-library-disk-2) page with a valid license key if you don't have a copy.
2. Open up the solution within src\MultiUnit. From the menu bar, hit Build > Build MultiUnit.
3. Now, install Inno Setup if you haven't.
4. Download the offline .NET 3.5 installer from [this page](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net35-sp1) and put it in the installer folder.
5. Build the installer with Inno Setup. If you are using Inno Setup 6 (requires Windows 7 or later), build the regular file, `multiunit-setup.iss`. However, if you are using Inno Setup 5 (definitely what you are using if you are on XP or Vista), there is a separate installer file that is written to work properly in Inno Setup 5. Its name is `multiunit-setup-is5.iss`.

6. # Building on non-Windows platforms
On macOS, you can use the free tier of JetBrains Rider. You also need Mono.framework somewhere in your /Library/Frameworks folder. You can use Inno Setup running in Wine to package the installer.

On Linux, you'll have to use Mono + MSBuild. You can use Inno Setup running in Wine the same way as you can in macOS.

# License
This project is licensed under GPLv3. This applies to all versions, present, past, and future. Please see the LICENSE file for full details.
