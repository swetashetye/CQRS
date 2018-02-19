using CQRSPattern.Model;
using CQRSPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern
{
    class Program
    {

        private static BookCommandService _commandService
           = new BookCommandService();
        private static BookQueryService _queryService
            = new BookQueryService();

        static void Main(string[] args)
        {
            Console.WriteLine("Press Key to create a Book...");
            Console.ReadLine();

            _commandService.CreateBook(new BookDetails
            {
                Id = 6546,
                BookName = "Lean In",
                Author= "Sheryl Sandberg",
                Language = "English",
                Price = 3500,
                PublicationYear = 2012
            });

            _commandService.CreateBook(new BookDetails
            {
                Id = 123587,
                BookName = "MS .Net Core",
                Author = "Karmanchi",
                Language = "English",
                Price = 1250,
                PublicationYear = 2007
            });
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Press Key to read the all Book info...");
            Console.ReadLine();

            Book Book = _queryService.GetBook(6546);

            Console.WriteLine("Book: " + Book.BookName);
            Console.WriteLine("Year: " + Book.PublicationYear);
            Console.WriteLine("Price: " + Book.Price);

            Console.WriteLine("--------------------------------------");
            Book sBook = _queryService.GetBook(123587);

            Console.WriteLine("Book: " + sBook.BookName);
            Console.WriteLine("Year: " + sBook.PublicationYear);
            Console.WriteLine("Price: " + sBook.Price);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Press Key to update Book year...");
            Console.ReadLine();

            _commandService.ChangeBookYear(Book.Id, 2007);

            Console.WriteLine("Press Key to get Books from 2007...");
            Console.ReadLine();

            List<Book> Books = _queryService.GetBookFromYear(2007);
            foreach (var c in Books)
            {
                Console.WriteLine("2007 Book brand: " + c.BookName);
            }
            Console.WriteLine("--------------------------------------");
            Console.ReadLine();

        }
    }
}
