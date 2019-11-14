using System.Collections.Generic;

namespace BookAccounting.Data.Repositories
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Add(TEntity entity);
        TEntity FindById(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}