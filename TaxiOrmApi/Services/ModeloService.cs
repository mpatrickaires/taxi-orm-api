using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.ModeloModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class ModeloService : GenericService<Modelo, ModeloDto>, IModeloService
    {
        public ModeloService(IModeloRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
