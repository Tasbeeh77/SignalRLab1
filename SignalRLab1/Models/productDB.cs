using Microsoft.EntityFrameworkCore;

namespace SignalRLab1.Models
{
    public class productDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=productDB;Trusted_Connection=True;encrypt=false");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
