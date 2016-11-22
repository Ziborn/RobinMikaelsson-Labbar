using Labb_14___Klass_Obj_Arv_Poly.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Klass_Obj_Arv_Poly.Classes
{
    class PublicationManager
    {
        Book book = new Book();
        Magazine magazine = new Magazine();
        Paper paper = new Paper();
        Author author = new Author();
        List list = new List();

        public void FindAuthor()
        {
            Console.Clear();
            ShowAuthors();
            Console.Write("Enter the name of the Author: ");

            string input = Console.ReadLine();

            var getBooks = list.BooksList.Where(author => author.Author.Name.Contains(input));
            var getMagazines = list.MagazinesList.Where(author => author.Author.Name.Contains(input));
            var getPapers = list.PaperList.Where(author => author.Author.Name.Contains(input));

            if (getBooks.Any() || getMagazines.Any() || getPapers.Any())
            {
                int i = 1;
                foreach (var author in getBooks)
                {
                    Console.WriteLine(i + ". " + "Title: {0} | Genre: {1} | Author: {2} | Pages: {3} | Release date: {4}",
                        author.Title, author.Genre, author.Author.Name, author.Pages, author.ReleaseDate.ToShortDateString()); i++;
                }
                foreach (var author in getMagazines)
                {
                    Console.WriteLine(i + ". " + "Title: {0} | Genre: {1} | Author: {2} | Pages: {3} | Release date: {4}",
                        author.Title, author.Genre, author.Author.Name, author.Pages, author.ReleaseDate.ToShortDateString()); i++;
                }
                foreach (var author in getPapers)
                {
                    Console.WriteLine(i + ". " + "Title: {0} | Genre: {1} | Author: {2} | Pages: {3} | Release date: {4}",
                        author.Title, author.Genre, author.Author.Name, author.Pages, author.ReleaseDate.ToShortDateString()); i++;
                }
            }


            else
            {Console.WriteLine("No author found...");
            }
            Console.ReadKey();
        }
        

        public void ShowAuthors()
        {
            int i = 1;
            foreach (var author in list.AuthorsList)
            {
                Console.WriteLine(i + ". " + author.Name); i++;
            }
        }

        public void ShowPublications()
        {
            Console.Clear();
            int i = 1;
            foreach (var author in list.BooksList)
            {
                Console.WriteLine(i + ". " + "Title: {0} | Genre: {1} | Author: {2} | Pages: {3} | Release date: {4}", 
                    author.Title, author.Genre, author.Author.Name, author.Pages, author.ReleaseDate.ToShortDateString()); i++;
            }
            foreach (var author in list.MagazinesList)
            {
                Console.WriteLine(i + ". " + "Title: {0} | Genre: {1} | Author: {2} | Pages: {3} | Release date: {4}",
                    author.Title, author.Genre, author.Author.Name, author.Pages, author.ReleaseDate.ToShortDateString()); i++;
            }
            foreach (var author in list.PaperList)
            {
                Console.WriteLine(i + ". " + "Title: {0} | Genre: {1} | Author: {2} | Pages: {3} | Release date: {4}",
                    author.Title, author.Genre, author.Author.Name, author.Pages, author.ReleaseDate.ToShortDateString()); i++;
            }
            Console.ReadKey();
        }
    }
}
