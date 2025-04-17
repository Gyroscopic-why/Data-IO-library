using System;
using System.Collections.Generic;
using static System.Console;

using static DataManipulationTest.CustomFunctions;

namespace DataManipulationTest
{
    class Program
    {
        static void Main()
        {
            //  Get a path for the files
            string path = GetPath(true, "\\Gyroscopic\\DataManipulation\\TestData", true);
            Write("\n\tChosen path: " + path + "\n\n");


            //  Read the data from the demo file
            List<string> data = ReadData(path, "Test data1.db", true);


            //  If any data is found
            if (data != null)
            {
                //  Output the found data
                Write("\n\tStock read data from file >Test data1.db<:");
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\tdata[" + i + "] = " + data[i]);
                }
            }
            WaitForKey();

            
            //  Parse the read data
            List<string> parsedData = ParseData(data, true, true, "$@", "#", "$@", true);


            //  If the parsing was successful
            if (parsedData != null)
            {
                //  Ouput the parsed data
                Write("\n\tParsed data from file >Test data1.db<:");
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\tparsedData[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForKey();


            //  Save the parsed data to a new file
            SaveData(path, "Test data2.db", data, true, true);
            WaitForKey();


            //  Read the data from the temporary file
            data = ReadData(path, "Test data2.db", true);


            //  If the data read was successful
            if (data != null)
            {
                //  Output the read data
                Write("\n\tStock read data from file >Test data2.db<:");
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\tdata[" + i + "] = " + data[i]);
                }
            }
            WaitForKey();


            //  Parse the read data
            parsedData = ParseData(data, true, true, "$@", "#", "$@", true);


            //  If the parsing was successful
            if (parsedData != null)
            {
                Write("\n\tParsed data from file >Test data2.db<:");
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\tparsedData[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForKey();


            //  Clear the temporary file
            ClearFile(path, "Test data2.db", true);
            WaitForKey();


            //  Read the data from the new file
            data = ReadData(path, "Test data2.db", true);


            //  If the data read was successful
            if (data != null)
            {
                //  Output the read data
                Write("\n\tStock read data from file >Test data2.db<:");
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\tdata[" + i + "] = " + data[i]);
                }
            }
            WaitForKey();


            //  Delete the temporary file
            DeleteFile(path, "Test data2.db", true);
            Write("\n\tTest finished. Press any key to exit ");
            ReadKey();
        }
    }
}
