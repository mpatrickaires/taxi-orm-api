using System.Linq.Expressions;
using TaxiOrmApi.Models;

namespace TaxiOrmApi.Services.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodosPorExpressao(Expression<Func<TEntity, bool>> expression);
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
    }
}
