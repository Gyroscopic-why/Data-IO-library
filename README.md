# Data saving test
C# small library for easier data manipulation through C# code

_(made because the implementation through the standart C#  System.IO library is just pure pain)_

## Includes:
- string_____________        GetPath    (bool chooseCustomPathOrNot)
- List (string)_______     **ReadData   (string path, string fileName, bool showInfo)**
- void______________       **ClearData  (string path, string fileName, List<string> data, bool dontOverwrite, bool showInfo)**
- void______________       **DeleteData (string path, string fileName, bool showInfo)**
- void______________         WaitForKey()  //  Only used for the demo

### Features:
+ Handles errors
+ Throws caught exceptions (if met)
+ Can read and modify almost any file format (if the file isn't protected)
+ Can parse a user path, or use a custom

### Plans for the future:
+ Directory organisation
+ Directory manipulation
+ Improve GetPath(bool) logic
+ Add a CopyFile(string pathToFile, string fileName, bool showInfo) function
+ Better Demo (?)
+ Custom downloader (?)
