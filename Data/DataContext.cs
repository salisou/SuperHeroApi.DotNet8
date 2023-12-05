using Microsoft.EntityFrameworkCore;
using SuperHeroApi.DotNet8.Entities;

namespace SuperHeroApi.DotNet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
