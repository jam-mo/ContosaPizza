using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosaPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosaPizza.Data
{
    public class ContosaPizzaContext : DbContext

    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=JAMUS\SQLEXPRESS;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;TrustServerCertificate=True; ");
        }
    }
}
