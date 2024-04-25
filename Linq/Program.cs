using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           var books = new BookRepository().GetBooks();

            //
            // LINQ Quary operator

            //var cheaperbook = from b in books 
            //                  where b.Price < 10 
            //                  orderby b.Title
            //                  select b.Title;



            //
            // LINQ extension method
            //var cheapbook = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);



            //
            //var cheapbook = new List<Book>();

            //foreach (var book in books)
            //{
            //    if(book.Price < 10)
            //        cheapBook.Add(book);
            //}


            //foreach (var book in cheapbook)
            //{
            //    Console.WriteLine(book);
            //    //Console.WriteLine(book.Title + " " + book.Price);
            //}


            //

            var book = books.Single(b => b.Title == "ADO.Net book");

            Console.WriteLine(book.Title);

            // methods :
            // skip, take,count, max, min, sum, count, average
            //  first, last, single, where, singleordefault, lastordefualt


            var maxprice = books.Max(b => b.Price);
            Console.WriteLine(maxprice);
            var minprice = books.Min(b => b.Price);
            Console.WriteLine(minprice);



        }
    }
}
