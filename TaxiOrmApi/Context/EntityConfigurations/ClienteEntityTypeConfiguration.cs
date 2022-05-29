using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.ClienteModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder
                .Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            builder
                .HasIndex(c => c.Cpf)
                .IsUnique();

            builder
                .Property(c => c.DataCadastro)
                .IsRequired();
        }
    }
}
