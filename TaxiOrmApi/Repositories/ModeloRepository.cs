using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models.ModeloModel;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class ModeloRepository : GenericRepository<Modelo>, IModeloRepository
    {
        public ModeloRepository(DbContext context) : base(context)
        {
        }
    }
}
