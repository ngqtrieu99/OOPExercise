using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace employeeObject
{
    public class Employee
    {
        public string Name {get; private set; }
        public int Age {get; private set; }
        public string Gender {get; private set; }
        public string Address {get; private set; }
        public string Role {get; private set; }

        public void SetProperty(string fullname, int Workerage, string genderWorker, string addressHome, string roleAtWork)
        {
            Name = fullname;
            Age = Workerage;
            Gender = genderWorker;
            Address = addressHome;
            Role = roleAtWork;
        }
    }
}