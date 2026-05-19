using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.Constructor
{
    internal class Book
    {

        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            //Console.WriteLine("Creating a new book...");  

            title = aTitle;
            author  = aAuthor;
            pages = aPages;
        }

        public Book()
        {

        }
    }
}
