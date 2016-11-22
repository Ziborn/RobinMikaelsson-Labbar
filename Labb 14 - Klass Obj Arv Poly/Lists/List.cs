using Labb_14___Klass_Obj_Arv_Poly.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Klass_Obj_Arv_Poly.Lists
{
    class List
    {

        public List<Author> AuthorsList { get; set; }
        public List<Book> BooksList { get; set; }
        public List<Magazine> MagazinesList { get; set; }
        public List<Paper> PaperList { get; set; }

        public List()
        {

            AuthorsList = new List<Author>
        {
            new Author {Name = "Mr Roberts", Age = 87 },
            new Author {Name = "Don rosa", Age = 65 },
            new Author {Name = "Labrador Kalle", Age = 87 },
            new Author {Name = "Pennsniffarn", Age = 87 },
            new Author {Name = "Skogens alla träd", Age = 87 }
        };

            BooksList = new List<Book>
        {
            new Book {Title = "Trolltyg", Genre = "Fantasy", Pages = 50, ReleaseDate = new DateTime(2016,08,09), Author = AuthorsList[0] },
            new Book {Title = "Misstyg", Genre = "Thriller", Pages = 250, ReleaseDate = new DateTime(2001,04,19), Author = AuthorsList[0]  },
            new Book {Title = "The Queen", Genre = "Drama", Pages = 500, ReleaseDate = new DateTime(1998,12,02), Author = AuthorsList[0] }
        };

            MagazinesList = new List<Magazine>
        {
            new Magazine {Title = "Musse Pigg", Genre = "Cartoon", Pages = 56, ReleaseDate = new DateTime(2016,06,06), Author = AuthorsList[2] },
            new Magazine {Title = "Pc gamer", Genre = "Games", Pages = 62, ReleaseDate = new DateTime(2005,09,09), Author = AuthorsList[3] },
            new Magazine {Title = "Kalle Anka", Genre = "Cartoon", Pages = 57, ReleaseDate = new DateTime(2015,07,13), Author = AuthorsList[1] }
        };

            PaperList = new List<Paper>
        {
            new Paper {Title = "Expressen", Genre = "News", Pages = 35, ReleaseDate = new DateTime(2016,11,09), Author = AuthorsList[3] },
            new Paper {Title = "Aftonbladet", Genre = "News", Pages = 35, ReleaseDate = new DateTime(2016,11,10), Author = AuthorsList[3] },
            new Paper {Title = "Lambi", Genre = "Bathroom", Pages = 200, ReleaseDate = new DateTime(2016,11,11), Author = AuthorsList[4] }
        };
        }
    }
}
