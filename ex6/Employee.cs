using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceObject;
using GlobalConfiguration;
namespace StaffObject
{
    class Employee
    {

        // Employee ID 
        public static int Id = 0; 

        public int EmpId { get; private set; } 

        public int GetId()
        {
            return EmpId;
        }

        // Name of employee
        public string FullName { get; private set; }
        public void SetName(string fullname)
        {
            FullName = fullname;
        }

        // Birth date of employee
        public DateOnly BirthDate { get; private set; }

        public void SetBirthDate(DateOnly birthdate)
        {
            BirthDate = birthdate;
        } 

        // phone number of employee
        public string PhoneNumber { get; private set; }
        public void SetPhoneNumber(string phonenumber)
        {
            PhoneNumber = phonenumber;
        }

        // email address of employee
        public string EmailAddress { get; private set; }
        public void SetEmailAddress(string emailaddress)
        {
            EmailAddress = emailaddress;
        }

        // Number of staff 
        public static int StaffCount = 0;
        public int EmpCount { get; private set; }
        public int GetEmpCount()
        {
            return EmpCount;
        }
        public void SetEmpCount()
        {
            EmpCount = StaffCount;
        }
        
        // Constructor 
        public Employee()
        {
            Id++;
            this.EmpId = Id;
            StaffCount++;
        }

    }
}