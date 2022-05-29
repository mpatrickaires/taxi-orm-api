using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.TelefoneClienteModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class TelefoneClienteEntityTypeConfiguration : IEntityTypeConfiguration<TelefoneCliente>
    {
        public void Configure(EntityTypeBuilder<TelefoneCliente> builder)
        {
            builder
                .Property(t => t.ClienteId)
                .IsRequired();

            builder
                .Property(t => t.Numero)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .HasOne(t => t.Cliente)
                .WithMany(c => c.Telefones);
        }
    }
}
