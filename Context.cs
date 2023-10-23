using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UoWRepository.Models;

namespace UoWRepository
{
    public class GameContext : DbContext
    {
        readonly string _constring;

        public GameContext()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            _constring = config.GetConnectionString("DefaultConnection")!;
        }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Game> Games { get; set; }

        public virtual DbSet<Studio> Studios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_constring);
        }
    }
}