using BookAccounting.Data.Models;
using System.Configuration;
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

            modelBuilder.Entity<IssuedBook>().HasOne((ib) => ib.Reader);
            modelBuilder.Entity<IssuedBook>().HasOne((ib) => ib.Book);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<IssuedBook> IssuedBooks { get; set; }
    }
}