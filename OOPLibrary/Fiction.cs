using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLibrary
{
    public class Fiction : Book
    {
        public string Genre { get; set; }
        public Fiction(string title, string author, string isbn, int year, string genre)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Year = year;
            Genre = genre;
        }
    }
}
