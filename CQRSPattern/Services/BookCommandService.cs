using CQRSPattern.DataStores;
using CQRSPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Services
{
   public class BookCommandService
    {
       
        public void CreateBook(BookDetails Book)
        {
            CommandDataStore.BookDetails.Add(Book);

            //update the read datastore
            ConsitencyWorker.Create(Book);
        }

        public void ChangeBookYear(int id, int year)
        {
            BookDetails Book =
                CommandDataStore.BookDetails.Single(c => c.Id == id);
            if (Book != null)
            {
                Book.PublicationYear = year;
            }

            //update the read datastore
            ConsitencyWorker.UpdateYear(id, year);
        }

        public void DeleteBook(int id)
        {
            CommandDataStore.BookDetails
                .Remove(CommandDataStore.BookDetails.Single(c => c.Id == id));

            //update the read datastore
            ConsitencyWorker.Delete(id);
        }
    }
}


