using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;
using System;

namespace MyLibrary.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
