using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pathDirection;
using ConstructorObject;
using employeeObject;
using engineerObject;
using Management;

namespace interfaceImplementation
{
    interface IDataCenter
    {
        // Fetch first 5 lines of the data table to a tempstring 
        // return a string array of 5 to convert it to the appropriate data type 
        List<string> fetch5Data(List<string> data);
    }
}
namespace dataProcess
{
    class DataOperations
    {
        // Read data from existing data path
        public static List<string> readData(string path)
        {
            string[] data = System.IO.File.ReadAllLines(path);
            List<string> dataConverted = data.ToList();
            return dataConverted;
        }

        public static List<string> remove5Data(ref List<string> data)
        {
            for(int i = 0; i < 5; i++)
            {
                data.RemoveAt(0);
            }
            return data;
        }


        public static void writeInformation(ref List<string> data, int type) 
        {
            Console.WriteLine("Do you want to save the data?");
            Console.WriteLine("Please press Y for 'Yes'' and N for 'No''");
            string path = GlobalConfiguration.paths[type];
            string dataFetch = String.Join(",", data);
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y: 
                File.AppendAllText(path, dataFetch + Environment.NewLine);
                break;
                default: 
                // Do nothing
                break;
            }
            
        }

        public static bool getAllInformation(ref string target)
        {
            bool success = false;
            string[] workers = File.ReadAllLines(@"C:\Users\supnep\Desktop\OOPExercise\ex1\data\constructor.txt");
            string[] employees = File.ReadAllLines(@"C:\Users\supnep\Desktop\OOPExercise\ex1\data\employee.txt");
            string[] engineers = File.ReadAllLines(@"C:\Users\supnep\Desktop\OOPExercise\ex1\data\engineer.txt  ");

            // Find in workers
            for(int i = 0; i < workers.Count(); i++)
            {
            if (Manager.getConstructorInfo(workers).ElementAt(i).name.Contains(target))  
            {  
                Console.WriteLine("WORKERS");
                Console.WriteLine("Name: {0}  Age: {1}  Gender: {2}  Address: {3}  level: {4}\n", 
                Manager.getConstructorInfo(workers)[i].name,
                Manager.getConstructorInfo(workers)[i].age,
                Manager.getConstructorInfo(workers)[i].gender,
                Manager.getConstructorInfo(workers)[i].address,
                Manager.getConstructorInfo(workers)[i].level);  
                Console.WriteLine("\n");
                success = true;
            }  
            }

            // Find in employee
            for(int i = 0; i < employees.Count(); i++)
            {
            if (Manager.getEmployeeInfo(employees).ElementAt(i).name.Contains(target))  
            {  
                Console.WriteLine("EMPLOYEE");
                Console.WriteLine("Name: {0}  Age: {1}  Gender: {2}  Address: {3}  Role: {4}\n", 
                Manager.getEmployeeInfo(employees)[i].name,
                Manager.getEmployeeInfo(employees)[i].age,
                Manager.getEmployeeInfo(employees)[i].gender,
                Manager.getEmployeeInfo(employees)[i].address,
                Manager.getEmployeeInfo(employees)[i].role);  
                Console.WriteLine("\n");
                success = true;
            }  
            } 

            // Find in engineer
            for(int i = 0; i < engineers.Count(); i++)
            {
            if (Manager.getEngineerInfo(engineers).ElementAt(i).name.Contains(target))  
            {  
                Console.WriteLine("ENGINEER");
                Console.WriteLine("Name: {0}  Age: {1}  Gender: {2}  Address: {3}  Job: {4}\n", 
                Manager.getEngineerInfo(engineers)[i].name,
                Manager.getEngineerInfo(engineers)[i].age,
                Manager.getEngineerInfo(engineers)[i].gender,
                Manager.getEngineerInfo(engineers)[i].address,
                Manager.getEngineerInfo(engineers)[i].field);  
                Console.WriteLine("\n");
                success = true;
            }  
            } 

        return success;
        }
    }
}
