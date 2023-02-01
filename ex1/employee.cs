using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1
{
    public class employee
    {
        public string name {get; set; }
        public int age {get; set; }
        public string gender {get; set; }
        public string address {get; set; }
        public string work {get; set; }
        employee(string name, int age, string gender, string address, string work)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.work = work;
        }
    }
}