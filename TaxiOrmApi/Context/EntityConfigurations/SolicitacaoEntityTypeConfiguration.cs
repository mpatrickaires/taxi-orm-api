using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiOrmApi.Models.SolicitacaoModel;

namespace TaxiOrmApi.Context.EntityConfigurations
{
    public class SolicitacaoEntityTypeConfiguration : IEntityTypeConfiguration<Solicitacao>
    {
        public void Configure(EntityTypeBuilder<Solicitacao> builder)
        {
            builder
                .Property(s => s.DataHora)
                .IsRequired();

            builder
                .Property(s => s.ClienteId)
                .IsRequired();

            builder
                .HasOne(s => s.Cliente)
                .WithMany(c => c.Solicitacoes);

            builder
                .Property(s => s.MotoristaId)
                .IsRequired();

            builder
                .HasOne(s => s.Motorista)
                .WithMany(m => m.Solicitacoes);

            builder
                .Property(s => s.LocalizacaoOrigemId)
                .IsRequired();

            builder
                .HasOne(s => s.LocalizacaoOrigem)
                .WithMany(lo => lo.SolicitacoesOrigem);

            builder
                .Property(s => s.LocalizacaoDestinoId)
                .IsRequired();

            builder
                .HasOne(s => s.LocalizacaoDestino)
                .WithMany(ld => ld.SolicitacoesDestino);
        }
    }
}
