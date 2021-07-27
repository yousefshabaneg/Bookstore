using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Models.Repositories
{
    public class AuthorDbRepository : IBookstoreRepository<Author>
    {
        private readonly BookstoreDbContext db;

        public AuthorDbRepository(BookstoreDbContext db)
        {
            this.db = db;
        }

        public void Add(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Authors.Remove(Find(id));
            db.SaveChanges();
        }

        public Author Find(int id)
        {
            var author = db.Authors.SingleOrDefault(b => b.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return db.Authors.ToList();
        }

        public void Update(int id, Author newAuthor)
        {
            db.Authors.Update(newAuthor);
            db.SaveChanges();
        }
    }
}
