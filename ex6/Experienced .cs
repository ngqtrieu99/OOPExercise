using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaffObject;
using GlobalConfiguration;
using InterfaceObject;

namespace ExperiencedEmployees
{
    class Experienced : Employee, IDataProcessor, IDataInput
    {
        public int ExpInYear { get; private set; }
        public void SetExpInYear(int expinyear)
        {
            this.ExpInYear = expinyear;
        }

        public List<string> JobSkills { get; private set; }
        public void SetJobSkills(string jobskills)
        {
            this.JobSkills.Add(jobskills);
        } 
    }
}