using System.Collections.Generic;
using System.Linq;
using BookAccounting.Data.Models;

namespace BookAccounting.Data.Repositories
{
    public class IssuedBooksRepository : IRepository<IssuedBook>
    {
        public IssuedBooksRepository()
        {
        }

        public List<IssuedBook> GetAll()
        {
            using (var db = new LibraryDbContext())
            {
                return db.IssuedBooks.ToList();
            }
        }

        public IssuedBook Add(IssuedBook entity)
        {
            using (var db = new LibraryDbContext())
            {
                var entry = db.IssuedBooks.Add(entity);
                db.SaveChanges();
                return entry.Entity;
            }
        }

        public IssuedBook FindById(int id)
        {
            using (var db = new LibraryDbContext())
            {
                return db.IssuedBooks.FirstOrDefault(b => b.Id == id);
            }
        }

        public void Update(IssuedBook entity)
        {
            using (var db = new LibraryDbContext())
            {
                db.IssuedBooks.Update(entity);
                db.SaveChanges();
            }
        }

        public void Delete(IssuedBook entity)
        {
            using (var db = new LibraryDbContext())
            {
                db.IssuedBooks.Remove(entity);
                db.SaveChanges();
            }
        }
    }
}