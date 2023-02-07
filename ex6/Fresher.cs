using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaffObject;
using GlobalConfiguration;
using InterfaceObject;

namespace FresherEmployee
{
    class Fresher : Employee, IDataProcessor, IDataInput
    {
        // Graduation date
        public DateOnly GraduationDate {get; private set; }

        public void SetGraduationDate(DateOnly graduationdate)
        {
            this.GraduationDate = graduationdate;
        }

        // Graduation Rank
        public GlobalVariable.CollegeRank GraduationRank {get; private set; }

        public void SetGraduationRank(GlobalVariable.CollegeRank rank)
        {
            this.GraduationRank = rank;
        }

        // Name of College/University
        public string CollegeName {get; private set; }
        
        public void SetCollegeName(string collegename)
        {
            this.CollegeName = collegename;
        }
    }
}