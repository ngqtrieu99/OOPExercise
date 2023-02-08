using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex15.src
{
    class Student
    {
        private static int Id = 0;

        public string FullName { get; private set; }

        public DateOnly DateOfBirth { get; private set; }

        public GlobalVariable.Gender Genders { get; private set; }

        public string PhoneNumber { get; private set; }

        public string University { get; private set; }

        public GlobalVariable.GraduatedLevel  Level {get; private set; }
    }
}