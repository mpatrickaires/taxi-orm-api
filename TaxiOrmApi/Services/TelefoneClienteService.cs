using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.TelefoneClienteModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class TelefoneClienteService : GenericService<TelefoneCliente, TelefoneClienteDto>, ITelefoneClienteService
    {
        public TelefoneClienteService(ITelefoneClienteRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
