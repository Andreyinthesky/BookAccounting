using System.Collections.Generic;

namespace BookAccounting.Data.Repositories
{
    public interface ICanGetAll<TEntity>
    {
        IEnumerable<TEntity> GetAll();
    }
}