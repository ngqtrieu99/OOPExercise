namespace ex1
{
    class Test
    {
        public static void Main()
        {
            string[] text1 = System.IO.File.ReadAllLines(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\constructor.txt");
            string[] text2 = System.IO.File.ReadAllLines(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\employee.txt");
            string[] text3 = System.IO.File.ReadAllLines(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\engineer.txt");
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
        }
    }
    
}
