using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>
            {
                new Book{Id=1, Title="ASP.NET CORE", Description="Core 3.1"},
                new Book{Id=2, Title="Angular Framework", Description="Version 8"},
                new Book{Id=3, Title="Bootstrap Development", Description="Version 4.5.0"}
            };
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Delete(int id)
        {
            books.Remove(Find(id));
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);

            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;
        }
    }
}
