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
                new Book{Id=1, Title="ASP.NET CORE", Description="Core 3.1", Author = new Author(), ImageUrl="asp.jpg" },
                new Book{Id=2, Title="Design Patterns", Description="Version 8", Author=new Author() , ImageUrl="cat.jpg"},
                new Book{Id=3, Title="C# Programming Language", Description="Version 4.5.0", Author=new Author(), ImageUrl="csharp.jpg" }
            };
        }

        public void Add(Book book)
        {
            book.Id = books.Max(x => x.Id) + 1;
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
            book.ImageUrl = newBook.ImageUrl;
        }
    }
}
