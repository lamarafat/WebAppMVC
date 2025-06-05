using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=webAppData;Trusted_Connection=True;TrustServerCertificate=True");
        }



    }
}
