using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceObject;
using StaffObject;

namespace InternshipEmployees
{
    public class Internship : IDataProcessor, IDataInput
    {
        public Employee employee = new Employee();
        public string Majorsubject { get; private set; }
        public int Currentsemester { get; private set; }
        public string Universityname { get; private set; }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        public void SetProperty(string majorsubject, int currentsemeter, string universityname)
        {
            Majorsubject = majorsubject;
            Currentsemester = currentsemeter;
            Universityname = universityname;
        }

        public void showInformation()
        {
            employee.showInformation();
            Console.WriteLine("Major subject: {0}\n Current Semester: {1}\n University name: {2}",
                              Majorsubject, Currentsemester, Universityname);
        }

        public void Input()
        {
            Console.WriteLine("Enter the full name: "); Console.ReadLine();
        }


    }
}