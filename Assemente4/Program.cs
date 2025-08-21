namespace Assemente4
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {

        #region Assem
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public double Price { get; set; }
        }

        public class BookFunctions
        {
            public static string GetTitle(Book b)
            {
                return b.Title;
            }

            public static string GetAuthors(Book b)
            {
                return b.Author;
            }

            public static string GetPrice(Book b)
            {
                return b.Price.ToString() + " EGP";
            }
        }

        public delegate string BookDelegate(Book b);

        public class LibraryEngine
        {
            public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
            {
                foreach (Book b in bList)
                {
                    Console.WriteLine(fPtr(b));
                }
            }
        }

      
            static void Main()
            {
                List<Book> books = new List<Book>()
        {
            new Book(){Title="C# Basics", Author="Ali", Price=150},
            new Book(){Title="OOP Concepts", Author="Sara", Price=200}
        };

                
                LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
                LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
                LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            }
        }
        #endregion


    }

