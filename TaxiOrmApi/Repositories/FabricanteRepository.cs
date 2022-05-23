using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models.FabricanteModel;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class FabricanteRepository : GenericRepository<Fabricante>, IFabricanteRepository
    {
        public FabricanteRepository(DbContext context) : base(context)
        {
        }
    }
}
