using System;
using Exceptions_HW.Models;

namespace Exceptions_HW.Controller
{
	public class LibraryControlller
	{
        public static void GetAll()
        {
            var libraries = Add();

            foreach (var library in libraries)
            {
                foreach (var book in library.Books)
                {
                    Console.WriteLine(book.Name);
                }
            }
        }

        public static List<Library> Add()
		{
			Book book1 = new Book()
			{
				Name = "Book1",
				Author = "Ali"
			};

            Book book2 = new Book()
            {
                Name = "Book2",
                Author = "Rehim"
            };

            Book book3 = new Book()
            {
                Name = "Book3",
                Author = "Asim"
            };

            Book book4 = new Book()
            {
                Name = "Book4",
                Author = "Cavad"
            };

            Book book5 = new Book()
            {
                Name = "Book5",
                Author = "Senan"
            };

            List<Book> books1 = new List<Book>() { book1, book2 };
            List<Book> books2 = new List<Book>() { book3, book4, book5 };

            Library library1 = new Library()
            {
                ID = 1,
                Name = "Lib1",
                Books = books1
            };

            Library library2 = new Library()
            {
                ID = 2,
                Name = "Lib2",
                Books = books2,
            };

            List<Library> libraries = new List<Library>() { library1, library2 };
            return libraries;
        }
	}
}

