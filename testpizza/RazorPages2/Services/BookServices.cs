using RazorPages2.Models;
using System.Collections.Generic;
using System.Linq;

namespace RazorPages2.Services
{
    public static class BookServices
    {
        static List<Book> Books { get; }
        static int id = 1;
        static BookServices()
        {
            Books = new List<Book>();
        }

        public static List<Book> GetAll() => Books;
        public static Book? Get(int id) => Books.FirstOrDefault(x => x.Id == id);
        public static void Add(Book book)
        {
            book.Id = id++;
            Books.Add(book);
        }
        public static void Delete(int id)
        {
            var book = Get(id);
            if (book != null)
                Books.Remove(book);
        }
    }
}
