
using Microsoft.EntityFrameworkCore;
using PetTech_API.Entities;

namespace PetTech_API.Data
{
    public class AppDbContext : DbContext
    {
        private IConfiguration Configuration;

        public AppDbContext(IConfiguration _Configuration)
        {
            Configuration = _Configuration;
        }
        public DbSet<Pet> Pets {get; set;}
        public DbSet<Breed> Breeds {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("User ID=postgres;Password=postgrespw;Host=localhost;Port=55000;Database=postgres;");
   }
}