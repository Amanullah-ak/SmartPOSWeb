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
    }
}
