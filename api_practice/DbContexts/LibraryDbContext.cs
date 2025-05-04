
using api_practice.Entities;
using Microsoft.EntityFrameworkCore;
namespace api_practice.DbContexts
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Books> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            // Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction" },
                new Category { Id = 2, Name = "Science" },
                new Category { Id = 3, Name = "History" },
                new Category { Id = 4, Name = "Children" }
            );

            // Authors
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, FullName = "F. Scott Fitzgerald" },
                new Author { Id = 2, FullName = "Harper Lee" },
                new Author { Id = 3, FullName = "Stephen Hawking" },
                new Author { Id = 4, FullName = "Carl Sagan" },
                new Author { Id = 5, FullName = "Yuval Noah Harari" },
                new Author { Id = 6, FullName = "Jared Diamond" },
                new Author { Id = 7, FullName = "J.K. Rowling" },
                new Author { Id = 8, FullName = "E.B. White" }
            );

            // Books
            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Description = "A novel about the American dream set in the 1920s.",
                    ISBN = "9780743273565",
                    Price = 12.99m,

                    AuthorId = 1,
                    CategoryId = 1,
                    PublishedDate = new DateTime(2024, 1, 1)
                },
                new Books
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Description = "A powerful story on racism and justice.",
                    ISBN = "9780060935467",
                    Price = 10.50m,

                    AuthorId = 2,
                    CategoryId = 1,
                    PublishedDate = new DateTime(2024, 1, 2)
                },
                new Books
                {
                    Id = 3,
                    Title = "A Brief History of Time",
                    Description = "A landmark volume in scientific writing.",
                    ISBN = "9780553380163",
                    Price = 18.00m,

                    AuthorId = 3,
                    CategoryId = 2,
                    PublishedDate = new DateTime(2024, 1, 3)
                },
                new Books
                {
                    Id = 4,
                    Title = "Cosmos",
                    Description = "Exploration of space and time.",
                    ISBN = "9780345539434",
                    Price = 20.00m,

                    AuthorId = 4,
                    CategoryId = 2,
                    PublishedDate = new DateTime(2024, 1, 4)
                },
                new Books
                {
                    Id = 5,
                    Title = "Sapiens: A Brief History of Humankind",
                    Description = "A global history of humankind.",
                    ISBN = "9780062316110",
                    Price = 16.75m,

                    AuthorId = 5,
                    CategoryId = 3,
                    PublishedDate = new DateTime(2024, 1, 5)
                },
                new Books
                {
                    Id = 6,
                    Title = "Guns, Germs, and Steel",
                    Description = "How civilizations developed differently across continents.",
                    ISBN = "9780393317558",
                    Price = 17.50m,

                    AuthorId = 6,
                    CategoryId = 3,
                    PublishedDate = new DateTime(2024, 1, 6)
                },
                new Books
                {
                    Id = 7,
                    Title = "Harry Potter and the Sorcerer’s Stone",
                    Description = "The magical beginning of the Harry Potter series.",
                    ISBN = "9780590353427",
                    Price = 9.99m,

                    AuthorId = 7,
                    CategoryId = 4,
                    PublishedDate = new DateTime(2024, 1, 7)
                },
                new Books
                {
                    Id = 8,
                    Title = "Charlotte’s Web",
                    Description = "A story of friendship between a pig and a spider.",
                    ISBN = "9780061124952",
                    Price = 7.99m,

                    AuthorId = 8,
                    CategoryId = 4,
                    PublishedDate = new DateTime(2024, 1, 8)
                }
            );

        }
    }
}
        
    



        //protected override void onconfiguring(dbcontextoptionsbuilder optionsbuilder)
        //{
        //    if (!optionsbuilder.isconfigured)
        //    {
        //        optionsbuilder.usesqlite();
        //        base.onconfiguring(optionsbuilder);
        //    }
        //}

  