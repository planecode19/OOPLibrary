using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLibrary
{
    public class Nonfiction : Book
    {
        public string Field { get; set; }

        public Nonfiction(string title, string author, string isbn, int year, string field)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Year = year;
            Field = field;
        }
    }
}
