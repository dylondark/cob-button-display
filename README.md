# Atrium Display
Display for the touchscreen in the UA College of Business atrium

Written in C#, WinForms, .NET Framework. Intended to be edited in Visual Studio (VS)

![Screenshot of application](/screenshot.PNG)

## Important Information
- Project will not build without the key. To solve this, go to the project properties in VS -> signing tab -> click "select from file..." -> select "Atrium_TemporaryKey.pfx" -> password is "Pass3word!"
- To get project onto display, go to "build" dropdown in VS -> click "publish atrium" -> specify the location to publish to and click next -> choose "from a CD-ROM or DVD-ROM" and click next -> choose "this application will not check for updates" and click next -> click finish -> get the installer onto the display computer and install it.
  - You may need to uninstall any older versions in control panel before installing the new version
  - Program will be launchable via start menu after install
- Debug mode can be entered by clicking/tapping the COB logo 5 times if you have built the project in the debug profile
- Program saves a csv file containing recorded activity in User\Documents\displaytest_output

## Project Goals
- Replace form2 with a simple dropdown on the directory button so we don't have to maintain two forms
- Potentially organize code into separate classes instead of having everything on the form class
- Write better documentation for functions and on how the project works in general
