# Atrium Display
Display for the touchscreen in the UA College of Business atrium

Written in C#, WinForms, .NET Framework. Intended to be edited in Visual Studio (VS)

![Screenshot of application](/screenshot.PNG)

## Important Information
- Project will not build without the key. To solve this, go to the project properties in VS -> signing tab -> click "select from file..." -> select "Atrium_TemporaryKey.pfx" -> password is "Pass3word!"
- Project will not run correctly without Visual C++ Redistributable 2015-2022 (x64)
- To get project onto display, go to "build" dropdown in VS -> click "publish atrium" -> specify the location to publish to and click next -> choose "from a CD-ROM or DVD-ROM" and click next -> choose "this application will not check for updates" and click next -> click finish -> get the installer onto the display computer and install it.
  - You may need to uninstall any older versions in control panel before installing the new version
  - Program will be launchable via start menu after install
  - This will build according to your selection of debug or release mode. It is recommended to publish in release mode if the published program is going to be used by the end users
- Debug mode can be entered by clicking/tapping the COB logo 5 times if you have built the project in the debug profile
- Program saves a csv file containing recorded activity in User\Documents\displaytest_output

## Project Goals
- Potentially organize code into separate classes instead of having everything on the form class
- Write better documentation for functions and on how the project works in general
