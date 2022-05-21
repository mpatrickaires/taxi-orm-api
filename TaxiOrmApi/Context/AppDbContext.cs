using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models;

namespace TaxiOrmApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Fabricante> Fabricantes { get; set; } = null!;
    }
}
