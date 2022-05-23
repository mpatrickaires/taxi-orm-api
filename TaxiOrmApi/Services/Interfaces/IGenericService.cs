using System.Linq.Expressions;
using TaxiOrmApi.Dtos;

namespace TaxiOrmApi.Services.Interfaces
{
    public interface IGenericService<TEntityDto> where TEntityDto : EntityDto
    {
        IEnumerable<TEntityDto> ObterTodos();
        TEntityDto ObterPorId(int id);
        IEnumerable<TEntityDto> ObterTodosPorExpressao(Expression<Func<TEntityDto, bool>> expression);
        void Inserir(TEntityDto entity);
        void Atualizar(TEntityDto entity);
        void Deletar(TEntityDto entity);
    }
}
