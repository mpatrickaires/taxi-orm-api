using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.ModeloModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class ModeloEntityTypeConfiguration : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder
                .Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(80);

            builder
                .Property(m => m.FabricanteId)
                .IsRequired();

            builder
                .HasOne(m => m.Fabricante)
                .WithMany(f => f.Modelos);
        }
    }
}
