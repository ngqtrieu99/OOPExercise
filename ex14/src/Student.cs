using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex14.src
{
    public class Student 
    {
        private static int Id = 0;

        public int StudentId { get; private set;}

        public string FullName { get; private set; }

        public DateOnly DateOfBirth { get; private set; }

        public Configurations.GlobalVariable.Gender Genders { get; private set; }

        public string PhoneNumber { get; private set; }

        public string University { get; private set; }

        public Configurations.GlobalVariable.GraduatedLevel  Level {get; private set; }

        public Student()
        {
            Id++;
            this.StudentId = Id;
        }

    }
}