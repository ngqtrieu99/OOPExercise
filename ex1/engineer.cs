using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace engineerObject
{
    public class Engineer 
    {
        public string Name {get; private set; }
        public int Age {get; private set; }
        public string Gender {get; private set; }
        public string Address {get; private set; }
        public string Field {get; private set; }

        public void SetProperty(string fullname, int Workerage, string genderWorker, string addressHome, string fieldAtWork)
        {
            Name = fullname;
            Age = Workerage;
            Gender = genderWorker;
            Address = addressHome;
            Field = fieldAtWork;
        }
    }
}