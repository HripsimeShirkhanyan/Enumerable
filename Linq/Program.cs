using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Book> books = new BookRepository().GetBooks();
            var cheapBooks = books
                                            .Where(b => b.Price < 10)
                                            .OrderBy(b => b.Title)
                                            .Select(b => b.Title);


            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
