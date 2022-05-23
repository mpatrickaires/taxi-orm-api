using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.MotoristaModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class MotoristaService : GenericService<Motorista, MotoristaDto>, IMotoristaService
    {
        public MotoristaService(IMotoristaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
