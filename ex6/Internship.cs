using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceObject;
using StaffObject;

namespace InternshipEmployees
{
    public class Internship : IDataProcessor
    {
        Employee _employee;
        public string MajorSubject { get; private set; }
        public int CurrentSememter { get; private set; }
        public int UniversityName { get; private set; }



        public void showInformation()
        {
            Console.WriteLine("ID: {0} \n Name: {1} \n "
                              + "Birth date: {2} \n Phone Number: {3} \n"
                              + "Personal Email: {4} \n + Staff level: {5}" );
        }
    }
}