# Data saving test
C# small library for easy data manipulation through C# code

_(made it because the implementation through the standart C#  System.IO library is just pure pain)_

## Includes:
- string_____________        GetPath    (bool chooseCustomPathOrNot)
- List (string)_______     **ParseData  (List(string) data, bool removeEmpty, bool removeWhiteSpace, string wsRemExc, string ignoreLineIfFound, string ignoreCharacters, bool showInfo)**
- List (string)_______     **ReadData   (string path, string fileName, bool showInfo)**
- void______________       **ClearData  (string path, string fileName, List<string> data, bool dontOverwrite, bool showInfo)**
- void______________       **DeleteData (string path, string fileName, bool showInfo)**
- void______________         WaitForKey()  //  Only used for the demo

### Features:
+ Handles errors
+ Throws caught exceptions (if met)
+ Can read and modify almost any file format (if the file isn't protected)
+ Has a strong parser for the read data
+ Can parse a user path, or use a custom

### Plans for the future:
+ (+) Split ReadData(): into ReadData() and ParseData()
+ (+) Improve GetPath() logic to use the documents folder
- Directory organisation
- Directory manipulation
- Improve GetPath() logic even move
- Improve ReadData() and SaveData()
- Add a CopyFile(string pathToFile, string fileName, bool showInfo) function
- Better Demo (?)
- Custom downloader (?)
