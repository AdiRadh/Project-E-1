using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E1_Classes.Products;
using E1_Classes.Site;
using E1_Classes.User;
using Microsoft.EntityFrameworkCore;

namespace E1_API.Data
{
    public class E1Context : DbContext
    {
        public E1Context(DbContextOptions<E1Context> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().ToTable("Tags");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Session>().ToTable("Session");
        }

    }

}
