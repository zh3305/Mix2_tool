

Unity Asset Editor
Version 0.2

Created by
Kyle N. Lane

Last Update
3/8/14


Introduction

Unity Asset Editor is a plug-in based asset editor, exporter, and importer for modding games created with the Unity Game Engine.  It can import and export any asset in raw data format.  It can also be extended to support any kind of asset type through the use of plug-ins.

This is an early version of UAE, so expect some bugs.  I also can't guarantee it will work with every game or every file.  If you find a file or game it doesn't work with let me know so I can figure out what's wrong.  Also any suggestions will be listened too, and if I can do it I will.


Using Unity Asset Editor

At the most basic level Unity Asset Editor can only browse the asset files, extract and import raw data, and save the changes back out to the asset file.  Most of the menus a self explanatory.  Saving and loading assets is in the file menu.  Importing and exporting individual assets is under the assets menu.  The Plug-ins menu contains a dialog with information about the installed plug-ins.  And the Help menu contains a dialog with information about the current build of UAE.

Using the Default Plug-ins

The plug-ins are the real powerhouse of the editor.  Each one can work with a different type of asset.  If the asset has a plug in that works with it, it will show a named asset type in the list view instead of a hex number.  Each plug-in can work in it's own unique way so you'll need to consult individual plug-ins on their exact use.  The Plug-ins Info Dialog shows information about each plug-in, and may contain instructions on it's use.

Default Audio Plugin

The Default Audio plug-in allows importing and exporting of audio files.  Each file internally is either a Wave or an Ogg Vorbis.  The Export dialog lets you select a file type, but the actual file exported will match it's original type.  You should only import files into files of the same type.

Default Text Plug-in
The default text plug-in allows editing of text directly inside of UAE.  It also allows the exporting and importing of text files and XML files.  The text editor supports plug-in decrypters for unknown decrypted files.  New with v0.2 I've included the 7 Days to Die Decrypter.

Default Texture Plug-in
The texture plug-in is probably the most complex of all the Default Plug-ins  The plug-in allows viewing a texture, and exporting/importing a texture in DDS format.  When a texture is selected the plug-in displays the texture and some information about the texture.  It's important to make note of the texture information, so you can create a compatible game texture.  The most important factors are mipmapping and compression.  Size shouldn't matter, unless it's a restriction imposed by the game itself. 

Mipmapping is simple, if a texture is mipmapped to begin with, then the texture you import should be mipmapped also.

Compression is a little different.  Textures are either compressed of uncompressed.  The other important thing to note is the presence of alpha channels.  The files I've come across are only four possible types.  If you find types that don't work let me know.  The four types are DXT1 compressed with no alpha channel.  DXT5 with implicit alpha channels, RGB 8.8.8 uncompressed, and RGBA 8.8.8.8 uncompressed.

Keep your imports with the same compression and mipmapping for compatibility with your game.

The main texture plug-in requires Direct X 9.0c.  If you don't have it the program will crash when you select a texture.  For now if you have this problem and are unable to install Direct X 9.0c I've included a no Direct X version of the mod in the Texture Plug-ins folder.

Default Hexidecimal Plug-in
The Hexidecimal Plug-in allows viewing the raw bytes of a file, and an ASCII readout of the file contents.  This plug-in can be used on any asset by selecting the Hexidecimal button below the asset list.

Default Mod Creator Plug-in
The Mod Creator Plug-in allows creating and packaging of mods for distribution.  It allows you to set some basic information about your mod, add files, and create a self contained install exe that you end user can use to install your mod.

The main thing you need to do is set the Install Directory to a directory above the assets files you are modifying.  The installer will search this directory and all sub directories until it finds your asset.  It will only install to the first asset it finds.

The Verify File field is useful, but not required.  In this field you select a file relative to your Install Directory.  This file must exist in the exact specified place, or the installation will fail.  This field can include child directories (ex. Mods\file.exe).

For a mod to do anything you must add files to it.  To add a file open up an asset that has your modded file, select it, and click the Add button.  The file will be added to the mod.  If you wish to remove a file you can select it in the Mod Files list, and click the Remove button.  The mod store a copy of the file, so to change or update a file you must first remove it, and then add the updated version.

The Icon field can be used to set a custom icon for you installer.  Right now it can only handle a very specific icon format.  That probably will change in the future.  For now use the provided  example icon to make your new icon.  The important thing to keep the same is icon numbers and sizes.

When your ready to release your mod simply click the Package button, select a save name, and click save.  The file that's created contains all the files you put in your mod, plus the install program, so your end user only has to follow a pretty standard installation process.

This plug-in can be used on any asset by selecting the Mod Creator button below the asset list.

Installing Plug-ins
The Unity Asset Editor allows extending it's functionality through plug-ins  Each of these controlling the editing,exporting, and importing of different assets.  Plug-ins need two files, a plg and a dll.  Plugin may also contain other files, and individual plug-ins should be consulted for specific instructions.  Simply place your plg and dll in the plug-ins folder.  You can even place them in folder inside this directory.  The editor will search the Plug-ins directory and all of it's sub directories for the plg files and load the plug-in  Plug-ins are first come first served, so if multiple plug-ins register the same asset only the first one will be usable.  All of them will be visible on the Plug-ins Info Dialog.

Creating A Plug-in
Creating a plug-in is easy at it's most basic level.  The real difficulty is in handling each asset.  To create a plug-in you must create a plg file and a dll.  Refer to the supplied Example Plugin for more information.

PLG Files
A plg file is an XML file that contains information about the name,author, version, and date of the plug-in  It also contains space for a detailed plug-in description, and instructions on the plug-ins use.  This information will be displayed when the user views your plug-in in the Plugin Info Dialog.  The mainLibrary attribute must be set to the name of your main dll.  The file name in mainLibrary will be appended to the directory of the PLG files so the dll can reside in lower directories, but not higher ones.

The last part of the PLG contains the id of the type of asset the plug-in handles, the name of the asset to be shown in the list view, and the file extensions the plug-in can handle.  Each plug-in can have up to ten different extensions, and each extension can be up to ten letters long.  The actual extension is put in the extension attribute, and the filter attribute contains the text that will be displayed for the extension in the Save/Load dialogs.

DLL Files
Your dll files can contain almost anything, but they must have certain functions in them.  These functions are explained in detail in the comments in dllMain.   Use the included project as a template for your dlls.

Change-log

2/20/14 

New Additions
•Added a right-click context menu for extracting and importing assets.
•Added a status bar.
•Added a preferences file that save information about directories, and window position.
•Added the Mod Creator Plug-in.
•Added the Hexidecimal Plug-in.

Bug Fixes
•Fixed Bug where selecting a plug-in on the plug-in dialog showed the incorrect information.
•Fixed Bug where selecting an item in the list view using the keyboard selected the incorrect item.
•Fixed Bug where message loop used unnecessary cycles.
•Fixed Bug where Texture plug-in would report the wrong DDS format.
•Fixed Bug where the selected plug-in remained displayed when opening a new file.
•Fixed Bug where exporting an unnamed asset would not export the entire file.
•Fixed Bug where file name lengths over 64 would cause a crash.

Other
•Cleaned some unused libraries from Texture Plugin.

2/20/14 
Initial Release
