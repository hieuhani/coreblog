using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Coreblog.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Blogging.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasIndex(b => b.Slug)
                .IsUnique();
            modelBuilder.Entity<Post>()
                .HasIndex(b => b.Slug)
                .IsUnique();
        }
    }
}