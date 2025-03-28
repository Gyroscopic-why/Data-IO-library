using System.Collections.Generic;
using static System.Console;

using static DataManipulationTest.CustomFunctions;

namespace DataManipulationTest
{
    class Program
    {
        static void Main()
        {
            string path = GetPath(true);
            Write("\n\tChosen path: " + path + "\n\n");

            List<string> data = ReadSavedData(path, "Test data1.txt", true);

            if (data != null)
            {
                Write("\n\tParsed data from file >Test data1.txt<:");
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\tfoundData[" + i + "] = " + data[i]);
                }
            }
            WaitForKey();



            SaveData(path, "Test data2.txt", data, true, true);
            WaitForKey();



            data = ReadSavedData(path, "Test data2.txt", true);

            if (data != null)
            {
                Write("\n\tParsed data from file >Test data2.txt<:");
                for (int i = 0; i < data.Count; i++)
                {
                    Write("\n\t\tfoundData[" + i + "] = " + data[i]);
                }
            }
            WaitForKey();



            ClearData(path, "Test data2.txt", true);
            WaitForKey();



            DeleteData(path, "Test data2.txt", true);
            Write("\n\tTest finished. Press any key to exit ");
            ReadKey();
        }
    }
}
