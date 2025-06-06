# Data manipulation C# custom library
C# custom library for easy data manipulation through C# code

_(made it because the standart implementation through the C#  System.IO library is just pure pain)_

## Includes functions
**BetterDataIO:**
###### Also every function supports two language info output (english and russian), custom margin, custom startLine and endLine
- string_____________      **GetPath        (bool chooseCustomPathOrNot, string makeSubFoldersInSystemPath, bool showInfo)**

- List (string)_______     **ReadData       (string path, string fileName, bool showInfo)**
- List (string)_______     **ReadBinaryData (string path, string fileName, bool showInfo)**
- List (string)_______     **ParseData      (List(string) data, bool removeEmpty, bool removeWhiteSpace, string whiteSpaceRemovalException, string ignoreLineIfFound, string ignoreCharacters, bool showInfo)**

~

- bool______________       **SaveData       (string path, string fileName, List(string) data, bool dontOverwrite, string splitDataBy, bool showInfo)**
- bool______________       **SaveBinaryData (string path, string fileName, List(byte[]) data, bool dontOverwrite, string splitDataBy, bool showInfo)**
- bool______________         SaveBinaryData (string path, string fileName, List(byte) data, bool dontOverwrite, string splitDataBy, bool showInfo)

~

- bool______________       **ClearData      (string path, string fileName, bool showInfo)**
- bool______________       **DeleteData     (string path, string fileName, bool showInfo)**

~

- string[]___________      **GetAllFiles    (string path, bool removePathFromFileNames, bool showInfo)**
- List (string)_______     **GetFilesWithExtension(string path, string extension, bool removePathFromFileNames, bool showInfo)**

~

- bool______________       **CopyFile       (string oldPath, string newPath, string oldName, string newName, bool showInfo)**
- bool______________       **MoveFile       (string oldPath, string newPath, string oldName, string newName, bool showInfo)**
- bool______________       **RenameFile     (string path, string oldName, string newName, bool showInfo)**
  
**TypeConversions:**
  
- List(byte)_________        ToByteList(byte[] array, int startIndex = 0, int endIndex = -1)
- List(sbyte)________        ToSByteList(sbyte[] array, int startIndex = 0, int endIndex = -1)
- byte[]_____________        ToByteArray(List(byte) list, int startIndex = 0, int endIndex = -1)
- sbyte[]____________        ToSByteArray(List(sbyte) list, int startIndex = 0, int endIndex = -1)

~

- List(short)_________        ToShortList(short[] array, int startIndex = 0, int endIndex = -1)
- List(ushort)________        ToUShortList(ushort[] array, int startIndex = 0, int endIndex = -1)
- short[]_____________        ToShortArray(List(short) list, int startIndex = 0, int endIndex = -1)
- ushort[]____________        ToUShortArray(List(ushort) list, int startIndex = 0, int endIndex = -1)

~

- List(int)_________        ToIntList(int[] array, int startIndex = 0, int endIndex = -1)
- List(uint)________        ToUIntList(uint[] array, int startIndex = 0, int endIndex = -1)
- int[]_____________        ToIntArray(List(int) list, int startIndex = 0, int endIndex = -1)
- uint[]____________        ToUIntArray(List(uint) list, int startIndex = 0, int endIndex = -1)

~

- List(long)_________        ToLongList(long[] array, int startIndex = 0, int endIndex = -1)
- List(ulong)________        ToULongList(ulong[] array, int startIndex = 0, int endIndex = -1)
- long[]_____________        ToLongArray(List(long) list, int startIndex = 0, int endIndex = -1)
- ulong[]____________        ToULongArray(List(ulong) list, int startIndex = 0, int endIndex = -1)

  
## Key features:
+ Handles any errors without crashes
+ Very easy to use (including non-standart C# functions, such as GetFilesWithExtension(), Rename(), etc.)
+ High functionality customisation
+ Can read and modify almost any file format (if the file isn't protected)
+ Has a strong parser for the read data
+ Has very safe realisation
+ GetPath will almost never be null
+ info output with 2 language support (english and russian) and custom text formatting

### Plans for the future:
+ (+) Split ReadData(): into ReadData() and ParseData()
+ (+) Improve GetPath() logic to use the documents folder
+ (+) Make the GetPath() logic absolutely safe
+ (+) Add multilanguage info output support
+ (+) Add custom info formatting
+ (+) Add a CopyFile(string pathToFile, string fileName, bool showInfo) function
- Directory organisation
- Path checker
- ReadWrite rights checker
- Directory manipulation
- Improve SaveData()
- Better Demo (?)
- Custom downloader (?)
