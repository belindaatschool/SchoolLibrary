using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addr = new Address("Gefen", 1, "Shoham", 1234);
            SchoolLib library = new SchoolLib("Shalevet", addr);
            //Console.WriteLine(library.ToString());

            Book b1 = new Book(1, "Harry Potter 1");
            Book b2 = new Book(2, "Harry Potter 2");
            Book b3 = new Book(3, "Harry Potter 3");
            Book b4 = new Book(4, "Harry Potter 4");
            Book b5 = new Book(5, "Harry Potter 5");
            Book b6 = new Book(6, "Harry Potter 6");
            Book b7 = new Book(7, "Harry Potter 7");
            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);
            library.AddBook(b4);
            library.AddBook(b5);
            library.AddBook(b6);
            library.AddBook(b7);
            library.RemoveBook(12);
            library.RemoveBook(2);
            Console.WriteLine(library.ToString());
        }
    }
}
