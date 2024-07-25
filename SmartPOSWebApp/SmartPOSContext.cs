using Microsoft.EntityFrameworkCore;
using SmartPOSWebApp.Models;
namespace SmartPOSWebApp
{
    public class SmartPOSContext : DbContext 
    {
        public SmartPOSContext(DbContextOptions<SmartPOSContext> options) 
            : base(options) 
        {                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<SmartPOSWebApp.Models.Customer> Customer { get; set; } = default!;
        public DbSet<SmartPOSWebApp.Models.Order> Order { get; set; } = default!;
    }
}
