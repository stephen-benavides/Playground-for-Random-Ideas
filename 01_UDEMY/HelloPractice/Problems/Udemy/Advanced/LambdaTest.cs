using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Advanced
{
    class LambdaTest
    {

    }
}

/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using HelloPractice.Problems.Random;
using HelloPractice.Problems.Udemy;
using HelloPractice.Problems.Udemy.Intermediate;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace HelloPractice
{
    class Program

    {
        public static void Main(string[] args)
        {

            Books books = new Books();
            BookRepository bookRepository = new BookRepository();


            // foreach (var book in bookRepository.GetBooks().FindAll(b =>b.Price < 8)) // Using Lambda expression 
            foreach (var book in bookRepository.GetBooks().FindAll(LessThan8)) //Using method LessThan8
            {
                Console.WriteLine(book.Name);
            }
        }

        public static bool LessThan8(Books book)
        {
            return book.Price < 8;
        }
    }

    class Books
    {
        public string Name { get; set; }
        public int Price { get; set; }

    }

    class BookRepository
    {
        public List<Books> GetBooks()
        {
            return new List<Books>
            {
                new Books() {Name = "1", Price = 10},
                new Books() {Name = "2", Price = 5},
                new Books() {Name = "3", Price = 8},
            };
        }
    }



}
*/
