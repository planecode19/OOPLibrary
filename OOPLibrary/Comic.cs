using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLibrary
{
    public class Comic : Book
    {
        public string Illustrator { get; set; }
        public Comic(string title, string author, string isbn, int year, string illustrator)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Year = year;
            Illustrator = illustrator;
        }
    }
}
