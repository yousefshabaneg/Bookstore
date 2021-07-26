using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
        List<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>
            {
                new Author{Id=1, FullName="Robert Martin"},
                new Author{Id=2, FullName="Reda Elbasiouny"},
                new Author{Id=3, FullName="Mosh Hamedani"},
            };
        }

        public void Add(Author author)
        {
            author.Id = authors.Max(a => a.Id) + 1;
            authors.Add(author);
        }

        public void Delete(int id)
        {
            authors.Remove(Find(id));
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(b => b.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);

            author.FullName = newAuthor.FullName;
        }
    }
}
