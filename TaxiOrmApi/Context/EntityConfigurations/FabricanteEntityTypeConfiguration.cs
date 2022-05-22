using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.FabricanteModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class FabricanteEntityTypeConfiguration : IEntityTypeConfiguration<Fabricante>
    {
        public void Configure(EntityTypeBuilder<Fabricante> builder)
        {
            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(80);
        }
    }
}
