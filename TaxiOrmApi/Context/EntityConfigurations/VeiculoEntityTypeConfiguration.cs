using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.VeiculoModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class VeiculoEntityTypeConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder
                .HasIndex(v => v.Renavam)
                .IsUnique();

            builder
                .Property(v => v.ModeloId)
                .IsRequired();

            builder
                .Property(v => v.Renavam)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            builder
                .Property(v => v.Ano)
                .IsRequired();

            builder
                .HasOne(v => v.Modelo)
                .WithMany();
        }
    }
}
