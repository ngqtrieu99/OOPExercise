using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employeeObject;
using engineerObject;
using ConstructorObject;

namespace Management
{
    public class Manager 
    {
        // Fetch all data from text file into the matched object
        public void getInPosition()
        {
            string constructorData = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\constructor.txt");
            string employeeData = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\employee.txt");
            string engineerData = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\engineer.txt");
            
            //employee[] employee = new employee();

        }

        public static void getConstructorInfo(int choice)
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

        public static void addStaff()
        {
            string[] job = {"Worker", "Employee", "Engineer"};
            Console.WriteLine("Please choose his role: \n 1. Worker \n 2. Employee \n 3. Engineer");
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                Constructor newAdd1 = new Constructor();
                Console.WriteLine("Please enter his/her information:");
                newAdd1.name = Console.ReadLine();
                newAdd1.age = 
                break;

                case ConsoleKey.D2:
                Employee newAdd2 = new Employee();
                Console.WriteLine("Please enter his/her information:");
                break;

                case ConsoleKey.D3:
                Engineer newAdd3 = new Engineer();
                Console.WriteLine("Please enter his/her information:");
                break;
            }
            
           
        }

       




    }
}