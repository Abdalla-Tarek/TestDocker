using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TestDocker.Models;

namespace TestDocker
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        // Override OnModelCreating for any additional configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configurations can go here
        }
    }
}
