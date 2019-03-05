using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    /// <summary>
    /// Structure cannot have parameterless constructor
    /// structures are value types whereas classes are ref types
    /// Structures can not have inheritance but they can implement interfaces
    /// </summary>
    struct Book
    {
        public string bookName;
        public int noOfpages;

        public void ReadBook()
        {
            Console.WriteLine("reading the Book");
        }

        public Book(string name, int np)
        {
            bookName = name;
            noOfpages = np;
        }
    }
    class Structures
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", 519);
            book.ReadBook();
            Console.WriteLine(book.bookName + " " + book.noOfpages);

            Console.ReadLine();

        }
    }
}
