using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceObject;
using StaffObject;
using GlobalConfiguration;
using InternshipEmployees;
using FresherEmployee;
using ExperiencedEmployees;


namespace ex6
{
    public class InstanceFactory
    {
        public static IDataProcessor GetInternship()
        {
            return new Internship();
        }

        public static IDataProcessor GetFresher()
        {
            return new Fresher();
        }

        public static IDataProcessor GetExperienced()
        {
            return new Experienced();
        }
    }
    }
