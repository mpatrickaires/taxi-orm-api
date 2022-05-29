using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.LocalizacaoModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class LocalizacaoEntityTypeConfiguration : IEntityTypeConfiguration<Localizacao>
    {
        public void Configure(EntityTypeBuilder<Localizacao> builder)
        {
            builder
                .Property(l => l.Cep)
                .HasMaxLength(11)
                .IsFixedLength();

            builder
                .Property(l => l.Uf)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength();

            builder
                .Property(l => l.Cidade)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(l => l.Bairro)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(l => l.Logradouro)
                .IsRequired()
                .HasMaxLength(60);

            builder
                .Property(l => l.Numero)
                .HasMaxLength(12);

            builder
                .Property(l => l.Complemento)
                .HasMaxLength(60);
        }
    }
}
