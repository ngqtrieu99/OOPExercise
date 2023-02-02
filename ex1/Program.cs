using joke;
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
                case ConsoleKey.D1: 
                
                break;

            }
        }
        public static void Main()
        {
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
                if(answer == "yes" 
                   || answer == "y" 
                   || answer == "Y" 
                   || answer== "YES") 
                {
                    Console.WriteLine(talk.yes);
                    start();
                    break;
                }
                else if((answer == "no" 
                        || answer == "n" 
                        || answer == "N" 
                        || answer== "NO"))
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
