using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex14.src
{
    public class GoodStudent : Student, ex15.service.IDataShowing
    {
        public float GPA {get; private set; }

        public string BestRewardName {get; private set; }

        public void SetGPA(float gpa)
        {
            this.GPA = gpa;
        }

        public void SetBestRewardName(string bestRewardName)
        {
            this.BestRewardName = bestRewardName;
        }

        public void ShowInfo()
        {
            Console.WriteLine(" ID: {0}\n Full name: {1}\n  Birthday: {2}\n Gender: {3}\n  Phone number {4}\n  University: {5}\n Level: {6}\n"
                             + "English score: {7}\n Entry score: {8}\n", StudentId, FullName, DateOfBirth, Genders, PhoneNumber, University, Level, GPA, BestRewardName);
        }
    }
}