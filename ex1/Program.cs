using System.Threading;
using conversations;
using Management;

namespace ex1
{
    class Test
    {
        public static void start()
        {
            int choice = 0;
            Console.WriteLine("Let's start with the menu okay!");
            Console.WriteLine("============================================");
            Console.WriteLine("|| Enter 1: To add new staff              ||");
            Console.WriteLine("|| Enter 2: To search staff by name       ||");
            Console.WriteLine("|| Enter 3: To show infomation of staffs  ||");
            Console.WriteLine("|| Enter 4: To Exit                       ||");
            Console.WriteLine("============================================");
            switch(Console.ReadKey(true).Key)
            {
                // Add new staff
                case ConsoleKey.D1: 
                        Manager.addStaff();
                        Console.WriteLine("Finished");
                        Thread.Sleep(2000);
                        start();
                break;

                case ConsoleKey.D2:
                        Manager.getStaffInfo();
                        Thread.Sleep(2000);
                        start();
                break;

                case ConsoleKey.D3:
                break;

                case ConsoleKey.D4:
                Console.WriteLine("Press any key to quit...");
                Console.ReadKey();
                break;

                default:
                Console.WriteLine("Sorry we do not accept other inputs but those four options. Please try again.");
                Thread.Sleep(2000);
                Console.WriteLine("Let's try again!");
                Console.Clear();
                start();
                break;

            }
        }
        public static void Main()
        {
            // Redundant input value that needs to be removed from user choice
            char[] charsToTrim = { '*', ' ', '\'', '\n'};

            string answer;
            Console.WriteLine("Hi man!");
            Thread.Sleep(2000);
            Console.WriteLine("We all know why you are here.");
            Thread.Sleep(2000);
            Console.WriteLine("Do you mind telling me what do you want to do?");
            int i = 0;
            while(i < 5)
            {
                answer = Console.ReadLine();

                // Tenary to check if answer is a blank input or something hmmm
                answer = (answer != null) ? answer.Trim(charsToTrim) : answer; 

                if(answer == "yes" 
                   || answer == "y" 
                   || answer == "Y" 
                   || answer == "YES"
                   || answer == "Yes") 
                {
                    Console.WriteLine(talk.yes);
                    start();
                    break;
                }
                else if((answer == "no" 
                        || answer == "n" 
                        || answer == "N" 
                        || answer == "NO"))
                {
                    Console.WriteLine(talk.no[talk.ranGenerator(talk.no.Count())]);
                }
                else
                {
                    Console.WriteLine(talk.blank[talk.ranGenerator(talk.blank.Count())]);
                }
                
                if(i == 5) Console.WriteLine("Sigh! Enough! Bye! I won't force you anymore! *Sob* *Sob*");
            }

            //Console.WriteLine(fun.hehe);
            
        }
    }
    
}
