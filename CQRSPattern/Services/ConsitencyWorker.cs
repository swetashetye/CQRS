using CQRSPattern.DataStores;
using CQRSPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Services
{
    public class ConsitencyWorker
    {
        public static void Create(BookDetails Book)
        {
            QueryDataStore.Book.Add(
                new Book
                {
                    Id = Book.Id,
                    BookName = Book.BookName,
                    Price = Book.Price,
                    PublicationYear = Book.PublicationYear
                }
            );
        }

        public static void UpdateYear(int id, int year)
        {
            Book Book = QueryDataStore.Book.Single(c => c.Id == id);
            if (Book != null)
            {
                Book.PublicationYear = year;
            }
        }

        public static void Delete(int id)
        {
            QueryDataStore.Book
                .Remove(QueryDataStore.Book.Single(c => c.Id == id));
        }
    }
}


