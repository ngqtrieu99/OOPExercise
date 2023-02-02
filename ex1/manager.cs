using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employeeObject;
using engineerObject;
//using ConstructorObject;

namespace Management
{
    class manager
    {
        // Fetch all data from text file into the matched object
        public void getInPosition()
        {
            string constructorData = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\constructor.txt");
            string employeeData = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\employee.txt");
            string engineerData = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\engineer.txt");
            
            //employee[] employee = new employee();

        }

        public void getConstructorInfo(int choice)
        {
            switch(choice)
            {
                //Constructor
                case 1: 
                //string text = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\constructor.txt");
                break;
                
                case 2:
                break;

                default:
                break;

            }
        }


    }
}