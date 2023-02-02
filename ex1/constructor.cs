using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace ConstructorObject
{
    public class constructor : IDataCenter
    {
        private string name {get; set; }
        private int age {get; set; }
        private string gender {get; set; }
        private string address {get; set; }
        private int level {get; set; }

        public void setProperty(string name, int Workerage, string gender, string address, int Workerlevel)
        {
            name = name.Trim('\n');
            age = Workerage;
            gender = gender.Trim('\n');
            address = address.Trim('\n');
            level = Workerlevel;
        }

        public void convertDataType(string[] data)
        {
            
        }

        public static List<string> fetch5Data(List<string> data)
        {
            List<string> list = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                list[i] = list.Add(data.ElementAt(0));            
            }
            return temp;
        }


    }
}