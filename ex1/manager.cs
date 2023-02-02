using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employeeObject;
using engineerObject;
using ConstructorObject;
using dataProcess;

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
        }

        public static void getStaffInfo()
        {
            string? target = null;
            Console.WriteLine("So my friend! Who do you want to search huh?");
            target = Console.ReadLine();
            if(DataOperations.getAllInformation(ref target) == false)
            {
                Console.WriteLine("Sorry man! Cannot find the person you are looking for");
                Console.WriteLine("Could you check again if you typed wrong or not?");
                Console.WriteLine("Remember that we require full name since the author is lazy af");
            }
        }

        public static List<Constructor> getConstructorInfo(string[] data)
        {
            List<Constructor> workerLst = new List<Constructor>();
            foreach (string line in data)
            {
                string[] temp = line.Split(',');
                if (temp.Length >= 0)
                {
                    Constructor contructors = new Constructor();
                    contructors.setProperty(temp[0],  
                                    Convert.ToInt32(temp[1]),
                                    temp[2], 
                                    temp[3],
                                    Convert.ToInt32(temp[4]));
                    workerLst.Add(contructors);
                }
            }
            return workerLst;
        }

        public static List<Employee> getEmployeeInfo(string[] data)
        {
            List<Employee> employeeLst = new List<Employee>();
            foreach (string line in data)
            {
                string[] temp = line.Split(',');
                if (temp.Length >= 0)
                {
                    Employee Employees = new Employee();
                    Employees.setProperty(temp[0],  
                                    Convert.ToInt32(temp[1]),
                                    temp[2], 
                                    temp[3],
                                    temp[4]);
                    employeeLst.Add(Employees);
                }
            }
            return employeeLst;
        }

        public static List<Engineer> getEngineerInfo(string[] data)
        {
            List<Engineer> engineerLst = new List<Engineer>();
            foreach (string line in data)
            {
                string[] temp = line.Split(',');
                if (temp.Length >= 0)
                {
                    Engineer Engineers = new Engineer();
                    Engineers.setProperty(temp[0],  
                                    Convert.ToInt32(temp[1]),
                                    temp[2], 
                                    temp[3],
                                    temp[4]);
                    engineerLst.Add(Engineers);
                }
            }
            return engineerLst;
        }

        public static void addStaff()
        {
            string[] job = {"Worker", "Employee", "Engineer"};
            Console.WriteLine("Please choose his role: \n 1. Worker \n 2. Employee \n 3. Engineer");
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                Constructor newAdd1 = new Constructor();
                List<string>informationWorker = new List<string>();
                // Enter the information
                Console.WriteLine("PLEASE ENTER HIS/HER INFORMATION BASED ON THESE GUIDELINES!");
                Console.WriteLine("Full name: "); informationWorker.Add(Console.ReadLine());
                Console.WriteLine("Age: "); informationWorker.Add(Console.ReadLine());
                Console.WriteLine("Gender: "); informationWorker.Add(Console.ReadLine());
                Console.WriteLine("Address: "); informationWorker.Add(Console.ReadLine());
                Console.WriteLine("Level: "); informationWorker.Add(Console.ReadLine());
                newAdd1.setProperty(informationWorker.ElementAt(0),  
                                    Int32.Parse(informationWorker.ElementAt(1)),
                                    informationWorker.ElementAt(2), 
                                    informationWorker.ElementAt(3),
                                    Int32.Parse(informationWorker.ElementAt(4)));
                DataOperations.writeInformation(ref informationWorker, 0);
                break;

                case ConsoleKey.D2:
                Employee newAdd2 = new Employee();
                List<string>informationEmployee = new List<string>();
                // Enter the information
                Console.WriteLine("PLEASE ENTER HIS/HER INFORMATION BASED ON THESE GUIDELINES!");
                Console.WriteLine("Full name: "); informationEmployee.Add(Console.ReadLine());
                Console.WriteLine("Age: "); informationEmployee.Add(Console.ReadLine());
                Console.WriteLine("Gender: "); informationEmployee.Add(Console.ReadLine());
                Console.WriteLine("Address: "); informationEmployee.Add(Console.ReadLine());
                Console.WriteLine("Role at work: "); informationEmployee.Add(Console.ReadLine());
                newAdd2.setProperty(informationEmployee.ElementAt(0),  
                                    Int32.Parse(informationEmployee.ElementAt(1)),
                                    informationEmployee.ElementAt(2), 
                                    informationEmployee.ElementAt(3),
                                    informationEmployee.ElementAt(4));
                DataOperations.writeInformation(ref informationEmployee, 1);
                break;

                case ConsoleKey.D3:
                Engineer newAdd3 = new Engineer();
                List<string>informationEngineer = new List<string>();
                // Enter the information
                Console.WriteLine("Please enter his/her information:");
                Console.WriteLine("PLEASE ENTER HIS/HER INFORMATION BASED ON THESE GUIDELINES!");
                Console.WriteLine("Full name: "); informationEngineer.Add(Console.ReadLine());
                Console.WriteLine("Age: "); informationEngineer.Add(Console.ReadLine());
                Console.WriteLine("Gender: "); informationEngineer.Add(Console.ReadLine());
                Console.WriteLine("Address: "); informationEngineer.Add(Console.ReadLine());
                Console.WriteLine("Main field "); informationEngineer.Add(Console.ReadLine());
                newAdd3.setProperty(informationEngineer.ElementAt(0),  
                                    Int32.Parse(informationEngineer.ElementAt(1)),
                                    informationEngineer.ElementAt(2), 
                                    informationEngineer.ElementAt(3),
                                    informationEngineer.ElementAt(4));
                DataOperations.writeInformation(ref informationEngineer, 2);
                break;
            }
            
           
        }

       




    }
}