using System;

namespace bookshop {
    internal class Programm {  
        static void Main(string[] args) {
            List<Book> books = new List<Book>();
            books.Add(new Book());
            foreach (var index in books) {
                Console.WriteLine(index.csv());
            }
            /*List<string> words = new List<string>();
            List<string> words = new();
            string a = "Three";
            words.Add("One");
            words.Add("Two");
            words.Add(a);
            words.Remove("Two");
            Console.WriteLine(words.Count());
            Console.WriteLine(date.ToString("d.M.yyyy"));
            foreach (string word in words) {
                Console.WriteLine(word);
            }*/
            /*
            List<Book> books = new();
            books.Add(new Book("Big Book", 3344556677, "Author of Big Book", new DateTime(2000, 1, 1)));
            Console.WriteLine(books.Select(1).csv());
            */
        }
    }
}