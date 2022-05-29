using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models.LocalizacaoModel;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class LocalizacaoRepository : GenericRepository<Localizacao>, ILocalizacaoRepository
    {
        public LocalizacaoRepository(DbContext context) : base(context)
        {
        }
    }
}
