using System.Collections.Generic;
using System.Linq;
using BookAccounting.Data.Models;

namespace BookAccounting.Data.Repositories
{
    public class ReadersRepository : IRepository<Reader>
    {
        public ReadersRepository()
        {
        }

        public List<Reader> GetAll()
        {
            using (var db = new LibraryDbContext())
            {
                return db.Readers.ToList();
            }
        }

        public Reader Add(Reader entity)
        {
            using (var db = new LibraryDbContext())
            {
                var entry = db.Readers.Add(entity);
                db.SaveChanges();
                return entry.Entity;
            }
        }

        public Reader FindById(int id)
        {
            using (var db = new LibraryDbContext())
            {
                return db.Readers.FirstOrDefault(b => b.Id == id);
            }
        }

        public void Update(Reader entity)
        {
            using (var db = new LibraryDbContext())
            {
                db.Readers.Update(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Reader entity)
        {
            using (var db = new LibraryDbContext())
            {
                db.Readers.Remove(entity);
                db.SaveChanges();
            }
        }
    }
}