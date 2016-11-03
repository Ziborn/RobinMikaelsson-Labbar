using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb4_MyRepository.DataStores.Repositories;

namespace Labb4_MyRepository.Controllers
{
    class BookController
    {
        private IRepositoriesBooks repositoryBooks = new ListRepositoriesBooks();

        public void AddBook()
        {
            var newBook = UI.AddBook();
            repositoryBooks.AddBook(newBook); 
        }
        
        public void CallBookMenu()
        {
            

            var loop = true;

            while (loop)
            {
                UI.ShowBookMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        ShowBookList();
                        break;
                    case ConsoleKey.D2:
                        AddBook();
                        break;
                    case ConsoleKey.D3:
                        EditBook();
                        break;
                    case ConsoleKey.D4:
                        RemoveBook();
                        break;
                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }
        public void ShowBookList()
        {
            Console.Clear();
            UI.ShowBookList(repositoryBooks.GetBooks());
            Console.ReadKey(true);
        }
        public void EditBook()
        {
            Console.Clear();
            var books = repositoryBooks.GetBooks();
            UI.ShowBookList(books);
            int index = UI.SelectBook(repositoryBooks.GetBooks()) - 1;

            UI.EditBook(books[index]);
        }
        public void RemoveBook()
        {
            var books = repositoryBooks.GetBooks();
            var index = UI.SelectBook(repositoryBooks.GetBooks()) - 1;
            repositoryBooks.RemoveBook(books[index]);
        }

    }
}
