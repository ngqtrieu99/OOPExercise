using System.Text.Json;
using System.Text.Json.Serialization;

namespace Test
{

    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Book(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }


    class JsonTest
    {
        public static void Main()
        {
            Book book = new Book(1, "Naruto", "Truyen nay chet lam the");
            List<Book> books = new List<Book>();
            books.Add(book);
            string json = JsonSerializer.Serialize(books);
            File.WriteAllText(@"C:\Users\supnep\Desktop\OOPExercise\jsontest\naruto.json", json);
        }
    }
}