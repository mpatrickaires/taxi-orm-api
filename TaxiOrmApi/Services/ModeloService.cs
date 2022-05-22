using TaxiOrmApi.Models.ModeloModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class ModeloService : ServiceBase<Modelo>, IModeloService
    {
        public ModeloService(IModeloRepository repository) : base(repository)
        {
        }
    }
}
