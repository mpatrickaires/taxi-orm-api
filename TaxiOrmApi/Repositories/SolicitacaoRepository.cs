using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models.SolicitacaoModel;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class SolicitacaoRepository : GenericRepository<Solicitacao>, ISolicitacaoRepository
    {
        public SolicitacaoRepository(DbContext context) : base(context)
        {
        }
    }
}
