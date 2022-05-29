using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.ClienteModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class ClienteService : GenericService<Cliente, ClienteDto>, IClienteService
    {
        public ClienteService(IClienteRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
