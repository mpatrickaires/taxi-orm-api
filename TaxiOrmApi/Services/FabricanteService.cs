using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.FabricanteModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class FabricanteService : GenericService<Fabricante, FabricanteDto>, IFabricanteService
    {
        public FabricanteService(IFabricanteRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
