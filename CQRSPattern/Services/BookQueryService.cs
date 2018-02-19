using CQRSPattern.DataStores;
using CQRSPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Services
{
    public class BookQueryService
    {
        public Book GetBook(int id)
        {
            return QueryDataStore.Book.Single(c => c.Id == id);
        }

        public List<Book> GetBookFromYear(int year)
        {
            return QueryDataStore.Book.Where(c => c.PublicationYear == year).ToList();
        }
    }
}


