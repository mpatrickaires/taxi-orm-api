using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models.VeiculoModel;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class VeiculoRepository : GenericRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(DbContext context) : base(context)
        {
        }
    }
}
