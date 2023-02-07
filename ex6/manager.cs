using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex6;
using GlobalConfiguration;
using InternshipEmployees;
using StaffObject;

namespace Manager
{
    public class Helperfunctions
    {
        public static List<string> input;  
        public static void LevelOptionDisplay()
        {  
            // Clear the console window
            Console.Clear();

            // Bring options to choose  
            Console.WriteLine("~~~~~Choose the level of employee~~~~~");
            Console.WriteLine("||                                  ||");        
            Console.WriteLine("|| 1.         Internship            ||");
            Console.WriteLine("|| 2.           Fresher             ||");
            Console.WriteLine("|| 3.         Experience            ||");
            Console.WriteLine("|| 4.           Go back             ||");
            Console.WriteLine("||                                  ||");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // Calling to catch event method
            LevelCatchEvent();
        }

        public static void LevelCatchEvent()
        {
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                     InstanceFactory.GetInternship();
                     break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                     
                     break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                     
                     break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                     Console.Clear();
                     Test.MenuDisplay();
                     break;
                default:
                    Console.WriteLine("Sorry! We don't accept other input");
                    LevelCatchEvent();
                    break;
            }
        }
    }
}
    
