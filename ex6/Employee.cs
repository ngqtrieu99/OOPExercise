using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceObject;
using GlobalConfiguration;
namespace StaffObject
{
    public class Employee : IDataProcessor
    {
        public static int Id = 0;
        public string FullName { get; private set; }
        public string BirthDay { get; private set; }
        public string PhoneNumber { get; private set; }
        public string PersonalEmail { get; private set; }
        public int StaffLevel { get; private set; }
        
        private static int staffCount = 0;
        public GlobalVariable.LevelStaff Officeposition { get; private set; }

        public int GetId()
        {
            return Id;
        }

        // Method to set properties of employee
        public void SetProperty(string fullname, string birth, string phone,
                                string email, int level, GlobalVariable.LevelStaff officeposition)
                    {
                        ++Id;
                        FullName = fullname;
                        BirthDay = birth;
                        PhoneNumber = phone;
                        PersonalEmail = email;
                        StaffLevel = level;
                        ++staffCount;
                        Officeposition = officeposition;
                    }
        public void showInformation() 
        {
            Console.WriteLine("ID: {0} \n FullName: {1} \n BirthDay: {2} \n PhoneNumber: {3} \n" +
                              "Personal Email: {4} \n Staff Level \n Position: {5}",
                              Id, FullName, BirthDay, PhoneNumber, PersonalEmail, StaffLevel, Officeposition);
        }
    }
}