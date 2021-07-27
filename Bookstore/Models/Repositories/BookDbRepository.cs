using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Models.Repositories
{
    public class BookDbRepository : IBookstoreRepository<Book>
    {
        private readonly BookstoreDbContext db;

        public BookDbRepository(BookstoreDbContext db)
        {
            this.db = db;
        }

        public void Add(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Books.Remove(Find(id));
            db.SaveChanges();
        }

        public Book Find(int id)
        {
            var book = db.Books.Include(a => a.Author).SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return db.Books.Include(a => a.Author).ToList();
        }

        public void Update(int id, Book newBook)
        {
            db.Books.Update(newBook);
            db.SaveChanges();
        }

        public List<Book> Search(string term)
        {
            var result = db.Books
                .Include(a => a.Author)
                .Where(b => b.Title.Contains(term) || b.Description.Contains(term) || b.Author.FullName.Contains(term));

            return result.ToList();
        }
    }
}
