using System.Collections.Generic;
using System.Linq;
using BookAccounting.Data.Models;

namespace BookAccounting.Data.Repositories
{
    public class BooksRepository : IRepository<Book>
    {
        public BooksRepository()
        {
        }

        public IEnumerable<Book> GetAll()
        {
            using (var db = new LibraryDbContext())
            {
                return db.Books.ToList();
            }
        }

        public Book Add(Book entity)
        {
            using (var db = new LibraryDbContext())
            {
                var entry = db.Books.Add(entity);
                db.SaveChanges();

                return entry.Entity;
            }
        }

        public Book FindById(int id)
        {
            using (var db = new LibraryDbContext())
            {
                return db.Books.FirstOrDefault(b => b.Id == id);
            }
        }

        public void Update(Book entity)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Update(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Book entity)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Remove(entity);
                db.SaveChanges();
            }
        }
    }
}