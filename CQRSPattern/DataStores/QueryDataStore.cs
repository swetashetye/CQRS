using CQRSPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.DataStores
{
    public class QueryDataStore
    {
        static QueryDataStore()
        {
            Book = new List<Book>();
        }

        public static List<Book> Book { get; set; }
    }
}


