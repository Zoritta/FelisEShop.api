using FelisEShop.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FelisEShop.api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products {set; get;}
        public DbSet<Customer> Customers { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}