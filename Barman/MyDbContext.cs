using System.Data.Entity;

namespace Barman
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {
        }

        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Cocktail> Cocktail { get; set; }
    }
}