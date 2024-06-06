using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLibrary
{
    public class Library
    {
        public List<Book> BookList = new List<Book>();

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }
        public void SaveToFile(string file)
        {
            File.WriteAllText(file, null);
            foreach (Book book in BookList)
            {
                File.AppendAllText(file, $"{book.Title}|{book.Author}|{book.ISBN}|{book.Year}\n");
            }
        }
        public string ShowBookList(string title, string author)
        {
            Book foundBook = BookList.First(t => (t.Title == title) && (t.Author == author));
            return $"{foundBook.Title} {foundBook.Author} {foundBook.ISBN} {foundBook.Year}";
        }
    }
}
