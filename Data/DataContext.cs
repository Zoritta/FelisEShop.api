using FelisEShop.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FelisEShop.api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products {set; get;}
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}