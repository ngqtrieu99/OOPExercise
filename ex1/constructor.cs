using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace ConstructorObject
{
    public class Constructor : IDataCenter
    {
        public string Name {get; private set; }
        public int Age {get; private set; }
        public string Gender {get; private set; }
        public string Address {get; private set; }
        public int Level {get; private set; }

        public void SetProperty(string fullname, int Workerage, string genderWorker, string addressHome, int Workerlevel)
        {
            Name = fullname;
            Age = Workerage;
            Gender = genderWorker;
            Address = addressHome;
            Level = Workerlevel;
        }

        public List<string> Fetch5Data(List<string> data)
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