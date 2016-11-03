using Labb4_MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.DataStores.Repositories
{
    class ListRepositoriesBooks : IRepositoriesBooks
    {
        public Book[] GetBooks()
        {
            return MyLists.Books.ToArray();
        }
        public void AddBook(Book newBook)
        {
            MyLists.Books.Add(newBook);
        }
        public void RemoveBook(Book removeBook)
        {
            MyLists.Books.Remove(removeBook);
        }
    }
}
