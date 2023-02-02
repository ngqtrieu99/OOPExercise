using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaceImplementation
{
    interface IDataCenter
    {
        // Fetch first 5 lines of the data table to a tempstring 
        // return a string array of 5 to convert it to the appropriate data type 
        List<string> fetch5Data(List<string> data);
    }

    class DataOperations
    {
        // Read data from existing data path
        public static List<string> readData(string path)
        {
            string[] data = System.IO.File.ReadAllLines(path);
            List<string> dataConverted = data.ToList();
            return dataConverted;
        }

        public static List<string> remove5Data(ref List<string> data)
        {
            for(int i = 0; i < 5; i++)
            {
                data.RemoveAt(0);
            }
            return data;
        }
    }
}