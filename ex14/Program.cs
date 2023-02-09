namespace ex15
{
    class MainRun
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Hello man!");
            Thread.Sleep(500);
            Console.WriteLine("Let me introduce you something new!");
            Thread.Sleep(500);
            ex14.src.Mangement managerObject = new ex14.src.Mangement();
            managerObject.DisplayMenu();
            
            return 0;
        }
    }
}

