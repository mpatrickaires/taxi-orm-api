using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models.MotoristaModel;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class MotoristaRepository : GenericRepository<Motorista>, IMotoristaRepository
    {
        public MotoristaRepository(DbContext context) : base(context)
        {
        }
    }
}
