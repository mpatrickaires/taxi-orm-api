using System.Linq.Expressions;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models;

namespace TaxiOrmApi.Services.Interfaces
{
    public interface IServiceBase<TEntity, TEntityDto>
        where TEntity : Entity
        where TEntityDto : EntityDto
    {
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodosPorExpressao(Expression<Func<TEntity, bool>> expression);
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
        void Validar(TEntity entity);
    }
}
