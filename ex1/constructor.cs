using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace ConstructorObject
{
    public class Constructor : IDataCenter
    {
        public string name {get; private set; }
        public int age {get; private set; }
        public string gender {get; private set; }
        public string address {get; private set; }
        public int level {get; private set; }

        public void setProperty(string fullname, int Workerage, string genderWorker, string addressHome, int Workerlevel)
        {
            name = fullname;
            age = Workerage;
            gender = genderWorker;
            address = addressHome;
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