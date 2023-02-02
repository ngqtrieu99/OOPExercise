using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace ConstructorObject
{
    public class Constructor : IDataCenter
    {
        public string name {get; set; }
        public int age {get; set; }
        public string gender {get; set; }
        public string address {get; set; }
        public int level {get; set; }

        public void setProperty(string name, int Workerage, string gender, string address, int Workerlevel)
        {
            name = name.Trim('\n');
            age = Workerage;
            gender = gender.Trim('\n');
            address = address.Trim('\n');
            level = Workerlevel;
        }

        public List<string> fetch5Data(List<string> data)
        {
            List<string> list = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                list[i] = data.ElementAt(i);            
            }
            return list;
        }


    }
}