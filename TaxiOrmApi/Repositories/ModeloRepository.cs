using Microsoft.EntityFrameworkCore;
using TaxiOrmApi.Models;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class ModeloRepository : RepositoryBase<Modelo>, IModeloRepository
    {
        public ModeloRepository(DbContext context) : base(context)
        {
        }
    }
}
