using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "ADO.Net book", Price = 2 },
                new Book() { Title = "ASP.Net book", Price = 4 },
                new Book() { Title = "C#.Net book", Price = 10 },
                new Book() { Title = "ASP.Net book", Price = 6 },
                new Book() { Title = "C#.Net book", Price = 18 }

            };
        }
    }
}
