using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.ModeloModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class ModeloService : ServiceBase<Modelo, ModeloDto>, IModeloService
    {
        public ModeloService(IModeloRepository repository) : base(repository)
        {
        }
    }
}
