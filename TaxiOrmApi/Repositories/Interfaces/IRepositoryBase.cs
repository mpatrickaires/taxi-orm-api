using System.Linq.Expressions;
using TaxiOrmApi.Models;

namespace TaxiOrmApi.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(Guid id);
        TEntity ObterPorExpressao(Expression<Func<TEntity, bool>> expressao);
        IEnumerable<TEntity> ObterTodosPorExpressao(Expression<Func<TEntity, bool>> expressao);
        void Salvar();
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Excluir(TEntity entity);
    }
}
