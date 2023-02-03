using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceObject;

namespace StaffObject
{
    public class Internship : Employee, IDataProcessor
    {
        public string MajorSubject { get; private set; }
        public int CurrentSememter { get; private set; }
        public int UniversityName { get; private set; }

        void showInformation()
        {
            Console.WriteLine("");
        }
        
    }
}