using Microsoft.EntityFrameworkCore;
using CookingAssist.Models;

namespace CookingAssist.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Recipe> Recipes { get; set; }
    }
}