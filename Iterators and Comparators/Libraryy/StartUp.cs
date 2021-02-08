using System;
using System.Collections.Generic;
using System.Linq;

namespace Libraryy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Document in the Case", 2013, "Dorothy Sayers","");
            Book bookThree = new Book("The Document in the Case",1996);

            Library libraryOne = new Library();
            libraryOne.Add(bookOne);
            libraryOne.Add(bookTwo);
            libraryOne.Add(bookThree);

            
            foreach (var book in libraryOne.OrderBy(n=>n.Year))
            {
                Console.WriteLine($"{book.Title}- {book.Year}");
            }
        }
    }
}
