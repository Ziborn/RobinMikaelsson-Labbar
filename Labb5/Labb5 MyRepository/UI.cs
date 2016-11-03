using Labb4_MyRepository.Controllers;
using Labb4_MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_MyRepository
{
    class UI
    {
        public static void PrintStartMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Book menu");
            Console.WriteLine("2. Pet menu");
            Console.WriteLine("3. Exit");
        }

        public static void ShowBookMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Show books");
            Console.WriteLine("2. Add book");
            Console.WriteLine("3. Edit book(s)");
            Console.WriteLine("4. Remove Book");
            Console.WriteLine("5. Return");
        }
        public static void ShowPetMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Show pets");
            Console.WriteLine("2. Add pet");
            Console.WriteLine("3. Edit pet(s)");
            Console.WriteLine("4. Remove pet");
            Console.WriteLine("5. Return");
        }

        public static Book AddBook()
        {
            Book newBook = new Book();
            Console.Clear();
            Console.Write("Book name: ");
            newBook.BookName = Console.ReadLine();

            Console.WriteLine("Choose a genre:  ");
            ShowBookGenres();
            Console.Write("Choice(1-5): ");
            int choice = int.Parse(Console.ReadLine());
            newBook.Genre = (Book.GenreTypeBook)choice;

            Console.Write("Author name: ");
            newBook.AuthorName = Console.ReadLine();

            Console.Write("Releaseyear: ");
            newBook.Year = int.Parse(Console.ReadLine());

            return newBook;
        }
        public static Pet AddPet()
        {
            Pet newPet = new Pet();
            Console.Clear();
            Console.Write("Pet name: ");
            newPet.PetName = Console.ReadLine();

            Console.WriteLine("Choose a type: ");
            ShowPetTypes();
            Console.WriteLine("Choice(1-5): ");
            int choice = int.Parse(Console.ReadLine());
            newPet.PetType = (Pet.PetCategory)choice;

            Console.Write("Pet age: ");
            newPet.PetAge = int.Parse(Console.ReadLine());
            
            return newPet;
        }

        private static void ShowPetTypes()
        {
            foreach (var type in Enum.GetValues(typeof(Pet.PetCategory)))
            {
                Console.WriteLine("{0}. {1} ", (int)type, type);
            }
        }

        public static void ShowBookGenres()
        {
            foreach (var genre in Enum.GetValues(typeof(Book.GenreTypeBook)))
            {
                Console.WriteLine("{0}. {1} ", (int)genre, genre);
            }
        }

        public static void ShowBookList(Book[] books)
        {
            Console.Clear();
            Console.WriteLine("Books: ");
            foreach (var book in books)
            {
                Console.WriteLine("{0}. Title: {1} | Author: {2} | Genre: {3} | Release: {4}", Array.IndexOf(books, book) + 1,
                    book.BookName, book.AuthorName, book.Genre, book.Year);
            }
        }

        public static void ShowPetList(Pet[] pets)
        {
            Console.Clear();
            Console.WriteLine("Pets: ");
            foreach (var pet in pets)
            {
                Console.WriteLine("{0}. Pet name: {1} | Pet type: {2} | Pet age: {3}", Array.IndexOf(pets, pet) + 1,
                    pet.PetName, pet.PetType, pet.PetAge);
            }
        }

        public static void EditBook(Book book)
        {
            Console.Clear();
            Console.WriteLine("1. Change Title");
            Console.WriteLine("2. Change Author");
            Console.WriteLine("3. Change Genre");
            Console.WriteLine("4. Change Release year");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine(("Title: {0} | Author: {1} | Genre: {2} | Release: {3}"), book.BookName, book.AuthorName, book.Genre, book.Year);

            switch(choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New Title: ");
                    book.BookName = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("New author: ");
                    book.AuthorName = Console.ReadLine();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Genre list");
                    ShowBookGenres();
                    Console.Write("New genre: ");
                    book.Genre = (Book.GenreTypeBook)int.Parse(Console.ReadLine());
                    break;
                case ConsoleKey.D4:
                    Console.Write("New releaseyear: ");
                    book.Year = int.Parse(Console.ReadLine());
                    break;
                    
            }
        }

        public static void EditPet(Pet pet)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change type");
            Console.WriteLine("3. change age");

            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Pet name: {0} | Type: {1} | Age: {2}", pet.PetName, pet.PetType, pet.PetAge);

            switch(choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    pet.PetName = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Pet types");
                    ShowPetTypes();
                    Console.Write("New type: ");
                    pet.PetType = (Pet.PetCategory)int.Parse(Console.ReadLine());
                    break;
            }
            
        }

        public static int SelectBook(Book[] books)
        {
            ShowBookList(books);
            Console.Write("Choose book: ");
            return int.Parse(Console.ReadLine());
        }
        public static int SelectPet(Pet[] pets)
        {
            ShowPetList(pets);
            Console.Write("Choose pet: ");
            return int.Parse(Console.ReadLine());
        }

    }
}
