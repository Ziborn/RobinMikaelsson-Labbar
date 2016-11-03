using Labb4_MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.DataStores.Repositories
{
    interface IRepositoriesBooks
    {
        Book[] GetBooks();
        void AddBook(Book newBook);
        void RemoveBook(Book removeBook);
    }
}
