using System.Diagnostics;
using System.Threading;
using GlobalConfiguration;

namespace ex6
{
    class Test
    {
        // Catching the user inputs
        public static void CatchEvent()
        {
            switch(Console.ReadKey(true).Key)
            {
                // Call to the infoInput method
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    infoInput();
                    break;
                
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    break;

                default:
                    Console.WriteLine("Sorry we don't accept other options");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MenuDisplay();
                    break;
            }
        }

        // Display the option menu for the user
        public static void MenuDisplay()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("||   Please enter your options:   ||");
            Console.WriteLine("||                                ||"); 
            Console.WriteLine("|| 1. Add new staff               ||"); 
            Console.WriteLine("|| 2. Search staff                ||");
            Console.WriteLine("|| 3. Edit the information        ||");
            Console.WriteLine("|| 4. Remove staff                ||");
            Console.WriteLine("|| 5. Exit                        ||");
            Console.WriteLine("||                                ||"); 
            Console.WriteLine("====================================");
            CatchEvent();
        }

        public static void Main()
        {
            Console.WriteLine("Hi man!");
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to my realm!");
            Thread.Sleep(1000);
            Console.WriteLine("Tell me what you want to do. We don't have the whole day so please be fast.");
            MenuDisplay();     
        }

        
    }
}