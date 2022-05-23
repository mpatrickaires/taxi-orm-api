using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.MotoristaModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class MotoristaEntityTypeConfiguration : IEntityTypeConfiguration<Motorista>
    {
        public void Configure(EntityTypeBuilder<Motorista> builder)
        {
            builder
                .Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(60)
                .IsFixedLength();

            builder
                .Property(m => m.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            builder
                .HasIndex(m => m.Cpf)
                .IsUnique();

            builder
                .Property(m => m.NumeroCnh)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            builder
                .HasIndex(m => m.NumeroCnh)
                .IsUnique();

            builder
                .HasOne(m => m.Veiculo)
                .WithOne(v => v.Motorista);
        }
    }
}
