using System.Collections.Generic;
using static System.Console;

using static DataManipulationTest.CustomFunctions;

namespace DataManipulationTest
{
    class Program
    {
        static void Main()
        {
            string path = GetPath(true, true);
            Write("\n\tChosen path: " + path + "\n\n");

            List<string> data = ReadData(path, "Test data1.db", true);

            if (data != null)
            {
                Write("\n\tStock read data from file >Test data1.db<:");
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\tdata[" + i + "] = " + data[i]);
                }
            }
            WaitForKey();

            List<string> parsedData = ParseData(data, true, true, "$@", "#", "$@", true);

            if (parsedData != null)
            {
                Write("\n\tParsed data from file >Test data1.db<:");
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\tparsedData[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForKey();



            SaveData(path, "Test data2.db", data, true, true);
            WaitForKey();



            data = ReadData(path, "Test data2.db", true);

            if (data != null)
            {
                Write("\n\tStock read data from file >Test data2.db<:");
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\tdata[" + i + "] = " + data[i]);
                }
            }
            WaitForKey();

            parsedData = ParseData(data, true, true, "$@", "#", "$@", true);

            if (parsedData != null)
            {
                Write("\n\tParsed data from file >Test data2.db<:");
                for (int i = 0; i < parsedData.Count; i++)
                {
                    Write("\n\t\tparsedData[" + i + "] = " + parsedData[i]);
                }
            }
            WaitForKey();



            ClearData(path, "Test data2.db", true);
            WaitForKey();



            DeleteData(path, "Test data2.db", true);
            Write("\n\tTest finished. Press any key to exit ");
            ReadKey();
        }
    }
}
