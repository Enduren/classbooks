using System;

namespace ClassprC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a object called book and giving it a title ,author , and pages
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 750;

            Console.WriteLine(book1.pages);
            Console.ReadLine();

        }
    }
}
