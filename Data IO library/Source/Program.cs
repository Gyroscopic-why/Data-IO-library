using System.Collections.Generic;

using static System.Console;


using static GyroscopicDataLibrary.BetterDataIO;
using static GyroscopicDataLibrary.DemoFunctions;
using static GyroscopicDataLibrary.TypeConversions;



namespace GyroscopicDataLibrary
{
    class Program
    {
        static void Main()
        {
            //  Set the language for the output
            //  True = english,  false = russian
            bool useEngLang = GetLanguage();

            if (useEngLang) Title = "Data IO Library demo";
            else Title = "Демо библиотеки для работы данными";


            //  Get a path for the files
            Write("\n\n\n\n\n\n");
            string path = GetPath(true, true, "\\Gyroscopic\\DataManipulation\\TestData", true, useEngLang);

            
            //  Ouput chosen path, accounting for the language
            if (useEngLang) Write("\n\tChosen path: " + path + "\n\n");
            else Write("\n\tВыбранный путь: " + path + "\n\n");
            WaitForAnyKey(false, useEngLang);



            //  Find files in the current directory
            string[] files = GetAllFiles(path, true, true);
            string[] txtFiles = ToStringArray(GetFilesWithExtension(path, ".txt", true, true, useEngLang));

            //  Print all found files
            for (int i = 0; i < files.Length; i++)
            {
                if (i < txtFiles.Length)
                {
                    if (useEngLang) Write("\tFound .txt file: " + txtFiles[i] + "\n");
                    else Write("\tНайден .txt файл: " + txtFiles[i] + "\n");
                }
                if (useEngLang) Write("\tFound file: " + files[i] + "\n");
                else Write("\tНайден файл: " + files[i] + "\n");
            }
            WaitForAnyKey(true, useEngLang);


            //  Read the data from the demo file
            List<string> data = ReadData(path, "Test data1.txt", true, useEngLang);


            //  If any data is found
            if (data != null)
            {
                //  Output the found data
                if (useEngLang) Write("\n\tStock read data from file >Test data1.txt<:");
                else Write("\n\tСчитанные данные из файла >Test data1.txt<:");

                //  Output the read data
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + data[i]);
                }
            }
            WaitForAnyKey(false, useEngLang);

            
            //  Parse the read data
            List<string> parsedData = ParseData(data, true, true, "$@", "#", "$@", true, useEngLang);


            //  If the parsing was successful
            if (parsedData != null)
            {
                //  Ouput the parsed data
                if (useEngLang) Write("\n\tParsed data from file >Test data1.txt<:");
                else Write("\n\tСчитанные данные из файла >Test data1.txt<:");

                //  Output the parsed data
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForAnyKey(true, useEngLang);


            //  Save the parsed data to a new file
            SaveData(path, "Test data2.txt", data, true, "\n", true, useEngLang);
            WaitForAnyKey(false, useEngLang);


            //  Read the data from the temporary file
            data = ReadData(path, "Test data2.txt", true, useEngLang);


            //  If the data read was successful
            if (data != null)
            {
                //  Output the read data
                if (useEngLang) Write("\n\tStock read data from file >Test data2.txt<:");
                else Write("\n\tСчитанные данные из файла >Test data2.txt<:");

                //  Output the read data
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + data[i]);
                }
            }
            WaitForAnyKey(false, useEngLang);


            //  Parse the read data
            parsedData = ParseData(data, true, true, "$@", "#", "$@", true, useEngLang);


            //  If the parsing was successful
            if (parsedData != null)
            {
                //  Ouput the parsed data
                if (useEngLang) Write("\n\tParsed data from file >Test data2.txt<:");
                else Write("\n\tСчитанные данные из файла >Test data2.txt<:");

                //  Output the parsed data
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForAnyKey(true, useEngLang);


            //  Clear the temporary file
            ClearFile(path, "Test data2.txt", true, useEngLang);
            WaitForAnyKey(true, useEngLang);


            //  Read the data from the new file
            data = ReadData(path, "Test data2.txt", true, useEngLang);


            //  If the data read was successful
            if (data != null)
            {
                //  Output the read data
                if (useEngLang) Write("\n\tStock read data from file >Test data2.txt<:");
                else Write("\n\tСчитанные данные из файла >Test data2.txt<:");

                //  Output the read data
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + data[i]);
                }
            }
            WaitForAnyKey(true, useEngLang);



            //  Delete the temporary file
            DeleteFile(path, "Test data2.txt", true, useEngLang);



            //  Output the demo end message
            if (useEngLang) Write("\n\tDemo finished. Press any key to exit ");
            else Write("\n\tДемо завершено. Нажмите любую клавишу для выхода ");

            //  Wait foy any user key to close the program
            ReadKey();
        }
    }
}
