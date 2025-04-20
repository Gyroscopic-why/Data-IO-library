using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

using static DataManipulationLibrary.CustomFunctions;

namespace DataManipulationLibrary
{
    class Program
    {
        static void Main()
        {
            Title = "Data Manipulation Library demo";

            //  Set the language for the output
            //  True = english,  false = russian
            bool useEngLang = true;

            
            //  Get a path for the files
            Write("\n\n\n\n\n\n");
            string path = GetPath(true, "\\Gyroscopic\\DataManipulation\\TestData", true, useEngLang);


            //  Ouput chosen path, accounting for the language
            if (useEngLang) Write("\n\tChosen path: " + path + "\n\n");
            else Write("\n\tВыбранный путь: " + path + "\n\n");
            WaitForAnyKey(false, useEngLang);


            //  Find files in the current directory
            string[] files = GetFiles(path, true, true);

            //  Print all found files
            for (int i = 0; i < files.Length; i++)
            {
                if (useEngLang) Write("\tFound file: " + files[i] + "\n");
                else Write("\tНайден файл: " + files[i] + "\n");
            }
            WaitForAnyKey(true, useEngLang);


            //  Read the data from the demo file
            List<string> data = ReadData(path, "Test data1.db", true, useEngLang);


            //  If any data is found
            if (data != null)
            {
                //  Output the found data
                if (useEngLang) Write("\n\tStock read data from file >Test data1.db<:");
                else Write("\n\tСчитанные данные из файла >Test data1.db<:");

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
                if (useEngLang) Write("\n\tParsed data from file >Test data1.db<:");
                else Write("\n\tСчитанные данные из файла >Test data1.db<:");

                //  Output the parsed data
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForAnyKey(true, useEngLang);


            //  Save the parsed data to a new file
            SaveData(path, "Test data2.db", data, true, true, useEngLang);
            WaitForAnyKey(false, useEngLang);


            //  Read the data from the temporary file
            data = ReadData(path, "Test data2.db", true, useEngLang);


            //  If the data read was successful
            if (data != null)
            {
                //  Output the read data
                if (useEngLang) Write("\n\tStock read data from file >Test data2.db<:");
                else Write("\n\tСчитанные данные из файла >Test data2.db<:");

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
                if (useEngLang) Write("\n\tParsed data from file >Test data2.db<:");
                else Write("\n\tСчитанные данные из файла >Test data2.db<:");

                //  Output the parsed data
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForAnyKey(true, useEngLang);


            //  Clear the temporary file
            ClearFile(path, "Test data2.db", true, useEngLang);
            WaitForAnyKey(true, useEngLang);


            //  Read the data from the new file
            data = ReadData(path, "Test data2.db", true, useEngLang);


            //  If the data read was successful
            if (data != null)
            {
                //  Output the read data
                if (useEngLang) Write("\n\tStock read data from file >Test data2.db<:");
                else Write("\n\tСчитанные данные из файла >Test data2.db<:");

                //  Output the read data
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\t[" + i + "] = " + data[i]);
                }
            }
            WaitForAnyKey(true, useEngLang);



            //  Delete the temporary file
            DeleteFile(path, "Test data2.db", true, useEngLang);



            //  Output the demo end message
            if (useEngLang) Write("\n\tDemo finished. Press any key to exit ");
            else Write("\n\tДемо завершено. Нажмите любую клавишу для выхода ");

            //  Wait foy any user key to close the program
            ReadKey();
        }
    }
}
