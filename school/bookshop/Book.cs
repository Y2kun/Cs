using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookshop {
    public class Book {
        public string Title;
        public long Isbn;
        public string Publisher;
        public DateTime PublishingDate;

        public Book() {
            Console.WriteLine("Input the Title of the Book:");
            Title = Console.ReadLine();
            Console.WriteLine("Input the ISBN of the Book:");
            if (!long.TryParse(Console.ReadLine(), out Isbn)) {Console.WriteLine("Error Input Invalid");}
            Console.WriteLine("Input the Publisher of the Book:");
            Publisher = Console.ReadLine();
            Console.WriteLine("Input the Publishing Date of the Book:");
            if (!DateTime.TryParse(Console.ReadLine(), out PublishingDate)) {Console.WriteLine("Error Input Invalid");}
        }

        public string csv() {
            return "Titel: " + Title + "\tISBN: " + Isbn + "\tPublisher: " + Publisher + "\tPublishing Date: " + PublishingDate.ToString("d.M.yyyy");
        }
    }
}