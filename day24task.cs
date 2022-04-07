using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace linq
{
    class day24task
    {
        public static void Main()
        {
            IList<Book> Bookdata = new List<Book>()
            {
                new Book{BookID=323,Title="Time to kill",Author="John grisham",Price=300},
                new Book{BookID=765,Title="The House of Mirth",Author="Edith Wharton",Price=420},
                new Book{BookID=985,Title="East of Eden",Author="Adam Steinbeck",Price=240}
            };
            var Bqry = from book in Bookdata
                       select book;
            foreach (var v in Bqry)
                Console.WriteLine(v.BookID + " " + v.Title + " " + v.Author + " "+ v.Price + " ");
            Console.WriteLine("*************************");

            var Bqry3 = from books in Bookdata
                        where books.Author.Contains("John grisham")
                        select books;
            foreach (var v in Bqry3)
                Console.WriteLine(v.Title);
            Console.WriteLine("*************************");

            var Bqry2 = from book in Bookdata
                        orderby book.Price
                        select book;
            foreach (var b in Bqry2)
                Console.WriteLine(b.Price + " " + b.Title);
            Console.WriteLine("****************************");


            var Bqry1 = from book in Bookdata
                        orderby book.Author
                        select book;
            foreach (var names in Bqry1)
                Console.WriteLine(names.Author + " " + names.Title);
                       



        }

    }
    class Book
    {
        public int BookID { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public int Price { get; set; }
    }
}
