# For The King - save game editor
This tool allows you to edit your Lore points as well as the gold and stats of your characters in your games.

Current release [1.1.8](https://github.com/warsnek/for-the-king-save-editor/releases/tag/1.1.8)

The editor is pretty simple to use, to start using it first download the latest version from the releases page, or [click here](https://github.com/warsnek/for-the-king-save-editor/releases/download/1.1.6/ForTheKingSaveGameEditor.1.1.8.zip).

Then unzip the file and run the "ForTheKingSaveEdit.exe" you should see an ugly screen :( like this:

![preview](https://github.com/warsnek/for-the-king-save-editor/blob/master/preview.png)
1. Here you can edit the amount of lore point you have to buy stuff from the store and using the "Enable Lore Store Options" you can unlock most items in the lore store so you can buy them.
2. Use this dropdown to select the savegame file that you want to edit.
3. Once you have selected a savegame file (2) you can select the character in this dropdown that you want to edit. You can edit the stats of the character in the nice blue section below.
4. When you are done click "Save and close" to save your changes or "Close without saving" to just exit from the editor.

Enjoy!

The tool now also has commandline options for manual unpacking/packing of the run files:
```
ForTheKingSaveEdit.exe --unpack --input:"C:\Users\[username]\AppData\LocalLow\IronOak Games\FTK\save\story_2019_9_7_0.run" --output:"C:\Temp\rawsave.json"
ForTheKingSaveEdit.exe --pack --input:"C:\Temp\rawsave.json" --output:"C:\Users\[username]\AppData\LocalLow\IronOak Games\FTK\save\story_2019_9_7_0.run" 
```
Make sure to backup your saves before editing, incase something goes wrong!


Note for devs: When you clone this project and try to build it from visual studio first run "Clean Solution" then Rebuild, without this it seems to have a problem with its SQLite nuget dependency.
