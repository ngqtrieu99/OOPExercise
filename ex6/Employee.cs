using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceObject;

namespace StaffObject
{
    public class Employee : IDataProcessor
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string BirthDay { get; private set; }
        public string PhoneNumber { get; private set; }
        public string PersonalEmail { get; private set; }
        public string StaffLevel { get; private set; }
        public string StaffCount { get; private set; }

        // Method to set properties of employee
        public void SetProperty(int id, string fullname, string birth, string phone,
                                string email, string level, string staffCount)
                    {
                        Id = id;
                        FullName = fullname;
                        BirthDay = birth;
                        PhoneNumber = phone;
                        PersonalEmail = email;
                        StaffLevel = level;
                        StaffCount = staffCount; 
                    }
        public void showInformation() 
        {
            Console.WriteLine("ID: {0} \n FullName: {1} \n BirthDay: {2} \n PhoneNumber: {3} \n" +
                              "Personal Email: {4} \n StaffLevel \n Number of staff: {5}",
                              Id, FullName, BirthDay, PhoneNumber, PersonalEmail, StaffLevel, StaffCount);
        }
    }
}