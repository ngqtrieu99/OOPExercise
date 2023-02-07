using InterfaceObject;
using StaffObject;
using ex6;

namespace InternshipEmployees
{
    class Internship : Employee, IDataProcessor, IDataInput
    {
        // Create a new instance of Employee classs
        public string MajorSubject { get; private set; }
        public int CurrentSemester { get; private set; }
        public string UniversityName { get; private set; }

        public void showInformation()
        {
            Console.WriteLine("ID: {0}\n Name: {1}\n Birth Date: {2}\n Phone number: {3}\n Email: {4}\n"
                               + "Major Subject: {5}\n Current Semester: {6}\n University Name: {7}\n"
                               ,EmpId, FullName, BirthDate, PhoneNumber, EmailAddress, 
                               MajorSubject, CurrentSemester, UniversityName);
        }

        public void Input()
        {
            Console.WriteLine("Please enter the following ID: ");
            InstanceFactory.GetInternship();

        }
    }
}   