using CQRSPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.DataStores
{
    public class CommandDataStore
    {
        static CommandDataStore()
        {
            BookDetails = new List<BookDetails>();
        }
        public static List<BookDetails> BookDetails { get; set; }
    }
}


