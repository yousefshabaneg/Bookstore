using System.Collections.Generic;

namespace Bookstore.Models.Repositories
{
    public interface IBookstoreRepository<TEntity>
    {
        IList<TEntity> List();

        TEntity Find(int id);

        void Add(TEntity entity);

        void Update(int id, TEntity entity);

        void Delete(int id);
    }
}
