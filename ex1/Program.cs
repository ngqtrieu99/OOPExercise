using System.Threading;
using conversations;
using Management;

namespace ex1
{
    class Test
    {
        public static void Start()
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
                        Manager.AddStaff();
                        Console.WriteLine("Finished");
                        Thread.Sleep(2000);
                        Start();
                break;

                case ConsoleKey.D2:
                        Manager.getTargetStaffInfo(false);
                        Thread.Sleep(2000);
                        Start();
                break;

                case ConsoleKey.D3:
                        Manager.getTargetStaffInfo(true);
                        Thread.Sleep(2000);
                        Start();
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
                Start();
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
            Console.WriteLine("Type Yes to Continue | No and you still have to continue...");
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
                    Start();
                    break;
                }
                else if((answer == "no" 
                        || answer == "n" 
                        || answer == "N" 
                        || answer == "NO")
                        || answer == "No")
                {
                    Console.WriteLine(talk.no[talk.RanGenerator(talk.no.Count())]);
                }
                else
                {
                    Console.WriteLine(talk.blank[talk.RanGenerator(talk.blank.Count())]);
                }
                
                if(i == 5) Console.WriteLine("Sigh! Enough! Bye! I won't force you anymore! *Sob* *Sob*");
            }          
        }
    }   
}
