using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.VeiculoModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class VeiculoService : GenericService<Veiculo, VeiculoDto>, IVeiculoService
    {
        public VeiculoService(IVeiculoRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
