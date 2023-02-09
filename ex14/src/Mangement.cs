using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex14.src
{
    public class Mangement
    {
        public enum UserChoice
        {
            Add = 1, Remove, Show, Search, Quit
        }
        public void DisplayMenu()
        {   
            Console.WriteLine("===============***===============");
            Console.WriteLine("||                             ||");
            Console.WriteLine("|| 1. Add the student          ||");
            Console.WriteLine("|| 2. Delete the student       ||");
            Console.WriteLine("|| 3. Show all students        ||");
            Console.WriteLine("|| 4. Search the students      ||");
            Console.WriteLine("|| 5. Exit the program         ||");
            Console.WriteLine("||                             ||");
            Console.WriteLine("||=============================||");
            CatchEvents();   
        }

        public void CatchEvents()
        {
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                     Start(UserChoice.Add);
                     break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                     Start(UserChoice.Remove);
                     break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                     Start(UserChoice.Show);
                     break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                     Start(UserChoice.Search);
                     break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                     Start(UserChoice.Quit);
                     break;

                default:
                     Console.WriteLine("Sorry we don't accept other inputs");
                     CatchEvents();
                     break;
            }
        }

        public void Start(UserChoice choice)
        {
            //Load all the existed data from json files
            switch(choice)
            {
                case UserChoice.Add:
                     var obj = 
                     WriteData(obj);
                     break;
            }

        }

        
        public void WriteData(object data)
        {   

        }

        public void LoadData()
        {

        }



    }
}