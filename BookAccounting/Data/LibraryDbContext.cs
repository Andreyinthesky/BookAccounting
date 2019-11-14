using BookAccounting.Data.Models;
using System.Configuration;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookAccounting.Data
{
    public sealed class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["LibraryDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(b => b.Id);
            modelBuilder.Entity<Reader>().HasKey(r => r.Id);
            modelBuilder.Entity<IssuedBook>().HasKey(ib => ib.Id);

            modelBuilder.Entity<Reader>().HasMany((r) => r.IssuedBooks).WithOne(ib => ib.Reader)
                .HasForeignKey(ib => ib.IdReader)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Book>().HasMany((b) => b.IssuedBooks).WithOne(ib => ib.Book)
                .HasForeignKey(ib => ib.IdBook)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Query<IssuedBookView>().ToQuery(() =>
                IssuedBooks.Include(ib => ib.Reader).Include(ib => ib.Book)
                    .Select(book => new IssuedBookView
                    {
                        Id = book.Id,
                        IdReader = book.IdReader,
                        IdBook = book.IdBook,
                        ReaderName = book.Reader.Name,
                        ReaderSurname = book.Reader.Surname,
                        ReaderPatronymic = book.Reader.Patronymic,
                        BookName = book.Book.BookName,
                        BookAuthorName = book.Book.AuthorName,
                        DateIssue = book.DateIssue,
                        DateReturn = book.DateReturn,
                    })
            );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<IssuedBook> IssuedBooks { get; set; }
    }
}