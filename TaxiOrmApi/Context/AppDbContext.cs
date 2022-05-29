using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaxiOrmApi.Models.ClienteModel;
using TaxiOrmApi.Models.FabricanteModel;
using TaxiOrmApi.Models.ModeloModel;
using TaxiOrmApi.Models.MotoristaModel;
using TaxiOrmApi.Models.TelefoneClienteModel;
using TaxiOrmApi.Models.VeiculoModel;

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

        public DbSet<Fabricante> Fabricante { get; set; } = null!;
        public DbSet<Modelo> Modelo { get; set; } = null!;
        public DbSet<Veiculo> Veiculo { get; set; } = null!;
        public DbSet<Motorista> Motorista { get; set; } = null!;
        public DbSet<Cliente> Cliente { get; set; } = null!;
        public DbSet<TelefoneCliente> TelefoneCliente { get; set; } = null!;
    }
}
