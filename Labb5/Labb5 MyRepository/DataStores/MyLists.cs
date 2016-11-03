using Labb4_MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository.DataStores
{
    class MyLists
    {
        private static List<Book> books;
         
        public static List<Book> Books
        {
            get
            {
                if (books == null)
                    books = new List<Book>();

                return books;
            }
        }

        private static List<Pet> pets = null;

        public static List<Pet> Pets
        {
            get
            {
                if (pets == null)
                    pets = new List<Pet>();

                return pets;
            }
        }
    }
}
