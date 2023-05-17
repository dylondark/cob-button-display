# Fisher Display
Display for the touchscreen in the UA Polsky Fisher Institute

Written in C#, WinForms, .NET Framework. Intended to be edited in Visual Studio (VS)

![Screenshot of application](/screenshot.png)

## Important Information
- Project will not build without the key. To solve this, go to the project properties in VS -> signing tab -> click "select from file..." -> select "Atrium_TemporaryKey.pfx" -> password is "Pass3word!"
- Project will not run correctly without Visual C++ Redistributable 2015-2022 (x64)
- To get project onto display, go to "build" dropdown in VS -> click "publish atrium" -> specify the location to publish to and click next -> choose "from a CD-ROM or DVD-ROM" and click next -> choose "this application will not check for updates" and click next -> click finish -> get the installer onto the display computer and install it.
  - You may need to uninstall any older versions in control panel before installing the new version
  - Program will be launchable via start menu after install
  - This will build according to your selection of debug or release mode. It is recommended to publish in release mode if the published program is going to be used by the end users
- Debug mode can be entered by clicking/tapping the COB logo 5 times if you have built the project in the debug profile
- Program saves a csv file containing recorded activity in User\Documents\displaytest_output

## Maintenance Information
- The web browser will likely need updated from time to time. To do this go to solution explorer in VS -> right click project file -> go to "manage nuget packages" -> updates tab -> select all cefsharp packages and update. Make a commit with ONLY THESE CHANGES and cherry pick it to all the other branches (or else VS may break for the other branches)
- All functions (unless they are extremely self explanatory) should have a comment above them explaining what they do in a sentence or two
- All window controls follow a naming scheme of a 3 or so letter abbreviation of the object type followed by the name (Ex. picLogo for a picturebox, lblDebug for a label, etc)
- Related functions (functions that are part of a single system like the stats system or the debug system) should be grouped into regions to assist readability (you can toggle their visibility in VS)
