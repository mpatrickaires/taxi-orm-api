using TaxiOrmApi.Models;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class FabricanteService : ServiceBase<Fabricante>, IFabricanteService
    {
        public FabricanteService(IFabricanteRepository repository) : base(repository)
        {
        }
    }
}
