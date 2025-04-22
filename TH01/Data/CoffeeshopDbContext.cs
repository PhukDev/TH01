using TH01.Models;
using Microsoft.EntityFrameworkCore;
namespace TH01.Data

{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) :
base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
