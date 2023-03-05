using Microsoft.EntityFrameworkCore;
using PetTech.Entities;

namespace PetTech.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("User ID=postgres;Password=postgrespw;Host=localhost;Port=55000;Database=postgres;");
    }
}