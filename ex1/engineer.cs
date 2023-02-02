using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace engineerObject
{
    public class Engineer 
    {
        public string name {get; private set; }
        public int age {get; private set; }
        public string gender {get; private set; }
        public string address {get; private set; }
        public string field {get; private set; }

        public void setProperty(string fullname, int Workerage, string genderWorker, string addressHome, string fieldAtWork)
        {
            name = fullname;
            age = Workerage;
            gender = genderWorker;
            address = addressHome;
            field = fieldAtWork;
        }
    }
}