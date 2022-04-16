using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
