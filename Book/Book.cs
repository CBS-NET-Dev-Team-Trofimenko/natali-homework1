using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        Content content { get; set; }
        Author autor { get; set; }
        Title title { get; set; }

      public Book( Author autor, Title title, Content content) // this is correct
        {
            this.content = content;
            this.autor = autor;
            this.title = title;
        }

        public void Show()
        {
            title.Show();
            autor.Show();
            content.Show();
        }


    }
}
