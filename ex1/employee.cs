using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace employeeObject
{
    public class Employee
    {
        public string name {get; private set; }
        public int age {get; private set; }
        public string gender {get; private set; }
        public string address {get; private set; }
        public string role {get; private set; }

        public void setProperty(string fullname, int Workerage, string genderWorker, string addressHome, string roleAtWork)
        {
            name = fullname;
            age = Workerage;
            gender = genderWorker;
            address = addressHome;
            role = roleAtWork;
        }
    }
}