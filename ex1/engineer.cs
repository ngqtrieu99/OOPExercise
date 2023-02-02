using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaceImplementation;

namespace engineerObject
{
    public class engineer 
    {
        public string name {get; set; }
        public int age {get; set; }
        public string gender {get; set; }
        public string address {get; set; }
        public string field {get; set; }

        engineer(string name, int age, string gender, string address, string field)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.field = field;
        }
    }
}