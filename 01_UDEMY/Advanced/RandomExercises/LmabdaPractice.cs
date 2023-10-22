using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    class LmabdaPractice
    {
    }

    class Book
    {
        public string Name { get; set; }
        public int Cost { get; set; }
    }

    class LibraryContext
    {
        public IEnumerable<Book> BooksSet()
        {
            return new List<Book>()
            {
                new Book() {Name = "Math", Cost = 250},
                new Book(){Name = "Science", Cost = 180}
            };
        }
    }

    public class ProgramMAIN
    {
        public static void MainPROGRAM(string[] args)
        {
            LibraryContext library = new LibraryContext();
            var query = library.BooksSet()
                .Where(b => b.Cost == 180);
                //.Select(new { });

            foreach (var v in query)
            {
                Console.WriteLine(v);
            }
        }
    }
}
