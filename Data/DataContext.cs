using Microsoft.EntityFrameworkCore;
using CookingAssist.Models;

namespace CookingAssist.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
            modelBuilder.HasDefaultSchema("public");
        }
        public DbSet<Recipe> recipes { get; set; }
    }
}