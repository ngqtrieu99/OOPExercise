using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace ConstructorObject
{
    public class constructor
    {
        public string name {get; set; }
        public int age {get; set; }
        public string gender {get; set; }
        public string address {get; set; }
        public int level {get; set; }

        public static void convertDataType(string[] data)
        {
            foreach(string line in data)
            {
                
            }
        }

        public static void fetchData()
        {
            Console.WriteLine("");
        }


        constructor(string name, int age, string gender, string address, int level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.level = level;
        }
    }
}