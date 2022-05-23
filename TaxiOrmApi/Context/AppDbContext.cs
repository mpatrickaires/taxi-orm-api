using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaxiOrmApi.Models.FabricanteModel;

namespace TaxiOrmApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var relacao in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relacao.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<Fabricante> Fabricantes { get; set; } = null!;
        public DbSet<Fabricante> Modelo { get; set; } = null!;
    }
}
