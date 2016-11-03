using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.Models
{
    class Book
    {
        public enum GenreTypeBook
        {
            Sciencefiction = 1,
            Thriller,
            Romantic,
            Horror,
            Crime
        }

        public string BookName { get; set; }
        public int Year { get; set; }
        public string AuthorName { get; set; }
        public GenreTypeBook Genre { get; set; }
    }
}
