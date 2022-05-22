using TaxiOrmApi.Models;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class ModeloService : ServiceBase<Modelo, ModeloValidator>, IModeloService
    {
        public ModeloService(IModeloRepository repository) : base(repository)
        {
        }
    }
}
