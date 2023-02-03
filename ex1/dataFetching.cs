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
        List<string> Fetch5Data(List<string> data);
    }
}
namespace dataProcess
{
    class DataOperations
    {
        // Read data from existing data path
        public static List<string> ReadData(string path)
        {
            string[] data = System.IO.File.ReadAllLines(path);
            List<string> dataConverted = data.ToList();
            return dataConverted;
        }

        public static List<string> Remove5Data(ref List<string> data)
        {
            for(int i = 0; i < 5; i++)
            {
                data.RemoveAt(0);
            }
            return data;
        }


        public static void WriteInformation(ref List<string> data, int type) 
        {
            Console.WriteLine("Do you want to save the data?");
            Console.WriteLine("Please press Y for 'Yes'' and N for 'No''");
            string path = GlobalConfiguration.paths[type];
            string dataFetch = String.Join(",", data);
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y: 
                File.AppendAllText(path, '\n' + dataFetch);
                break;
                default: 
                // Do nothing
                break;
            }
            
        }

        public static bool getAllInformation(ref string target)
        {
            bool success = false;
            string[] workers = File.ReadAllLines(GlobalConfiguration.paths[0]);
            string[] employees = File.ReadAllLines(GlobalConfiguration.paths[1]);
            string[] engineers = File.ReadAllLines(GlobalConfiguration.paths[2]);

            // Find in workers
            Console.WriteLine("WORKERS");
            for(int i = 0; i < workers.Count(); i++)
            {
            if (Manager.GetConstructorInfo(workers).ElementAt(i).Name.Contains(target))  
            {  
                Console.WriteLine("Name: {0}  Age: {1}  Gender: {2}  Address: {3}  level: {4}\n", 
                Manager.GetConstructorInfo(workers)[i].Name,
                Manager.GetConstructorInfo(workers)[i].Age,
                Manager.GetConstructorInfo(workers)[i].Gender,
                Manager.GetConstructorInfo(workers)[i].Address,
                Manager.GetConstructorInfo(workers)[i].Level);  
                success = true;
            } 
            }

            // Find in employee
            Console.WriteLine("EMPLOYEE");
            for(int i = 0; i < employees.Count(); i++)
            {
            if (Manager.GetEmployeeInfo(employees).ElementAt(i).Name.Contains(target))  
            {  
                Console.WriteLine("Name: {0}  Age: {1}  Gender: {2}  Address: {3}  Role: {4}\n", 
                Manager.GetEmployeeInfo(employees)[i].Name,
                Manager.GetEmployeeInfo(employees)[i].Age,
                Manager.GetEmployeeInfo(employees)[i].Gender,
                Manager.GetEmployeeInfo(employees)[i].Address,
                Manager.GetEmployeeInfo(employees)[i].Role);  
                success = true;
            }  
            } 

            // Find in engineer
            Console.WriteLine("ENGINEER");
            for(int i = 0; i < engineers.Count(); i++)
            {
            if (Manager.GetEngineerInfo(engineers).ElementAt(i).Name.Contains(target))  
            {  
                Console.WriteLine("Name: {0}  Age: {1}  Gender: {2}  Address: {3}  Job: {4}\n", 
                Manager.GetEngineerInfo(engineers)[i].Name,
                Manager.GetEngineerInfo(engineers)[i].Age,
                Manager.GetEngineerInfo(engineers)[i].Gender,
                Manager.GetEngineerInfo(engineers)[i].Address,
                Manager.GetEngineerInfo(engineers)[i].Field);  
                success = true;
            }  
            } 

        return success;
        }
    }
}
