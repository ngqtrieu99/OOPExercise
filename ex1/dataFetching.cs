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
        void fetch5Data();

        // Convert to the suitable data type depend on class properties
        void convertDataType(string[] data);
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

        public static string[] remove5Data(ref string[] data)
        {
            var foos = new List<foos>(data);
            foos.RemoveAt(0);
            return foos.ToArray();
        }
    }
}