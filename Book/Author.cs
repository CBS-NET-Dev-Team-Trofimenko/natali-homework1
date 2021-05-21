using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Author
    {

        private string autor;

        public Author(string autor)
        {
            this.autor = autor;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(autor);
        }

    }
}
