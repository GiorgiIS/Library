using Microsoft.EntityFrameworkCore;
using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Repository.EF
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

		public DbSet<Author> Authors { get; set; } 

		public DbSet<Book> Books { get; set; } 

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
