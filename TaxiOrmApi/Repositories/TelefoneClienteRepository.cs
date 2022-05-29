using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models.TelefoneClienteModel;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class TelefoneClienteRepository : GenericRepository<TelefoneCliente>, ITelefoneClienteRepository
    {
        public TelefoneClienteRepository(DbContext context) : base(context)
        {
        }
    }
}
