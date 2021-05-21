using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
        }



    }
}
