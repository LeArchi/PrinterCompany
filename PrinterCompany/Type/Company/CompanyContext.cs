using Microsoft.EntityFrameworkCore;
using PrinterCompany.Type.Company.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterCompany.Type.Company
{
    internal class CompanyContext : DbContext
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Payment> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>().HasData(
            //    new Book() { Title = "Moby Dick", AuthorId = 1 }
            //    );
            base.OnModelCreating(modelBuilder);
        }
    }
}
