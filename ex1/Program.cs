namespace ex1
{
    class Test
    {
        public static void Main()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\trieu.nguyen\Desktop\Exercise\ex1\data\constructor.txt");
            Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
    }
    
}
