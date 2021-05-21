using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new Author( "Natali"),new Title("Something"),new Content("something"));
            book.Show();
        }
    }
}
