using System.Collections.Generic;
using System.Linq;
using BookAccounting.Data.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

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
                return db.IssuedBooks.Include(ib => ib.Book).Include(ib => ib.Reader).ToList();
            }
        }

        public IssuedBook Add(IssuedBook entity)
        {
            using (var db = new LibraryDbContext())
            {
                var book = db.Books.FirstOrDefault(b => b.Id == entity.IdBook);

                if (book == null)
                    throw new SqliteException("book doesn't exists in database", 1);
                else if (book.Count <= 0)
                    throw new SqliteException("books count <= 0", 1);

                book.Count--;
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
                var book = db.Books.FirstOrDefault(b => b.Id == entity.IdBook);

                if (book == null)
                    throw new SqliteException("book doesn't exists in database", 1);

                book.Count++;
                db.IssuedBooks.Remove(entity);
                db.SaveChanges();
            }
        }
    }
}