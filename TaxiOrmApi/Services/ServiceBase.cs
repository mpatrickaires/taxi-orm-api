using FluentValidation;
using System.Linq.Expressions;
using TaxiOrmApi.Models;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class ServiceBase<TEntity, TEntityValidator> : IServiceBase<TEntity> where TEntity : Entity where TEntityValidator : AbstractValidator<TEntity>, new()
    {
        protected IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public virtual TEntity ObterPorExpressao(Expression<Func<TEntity, bool>> expressao)
        {
            return _repository.ObterPorExpressao(expressao);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public virtual IEnumerable<TEntity> ObterTodosPorExpressao(Expression<Func<TEntity, bool>> expressao)
        {
            return _repository.ObterTodosPorExpressao(expressao);
        }

        public virtual void Atualizar(TEntity entity)
        {
            Validar(entity);

            _repository.Atualizar(entity);
            _repository.Salvar();
        }

        public virtual void Deletar(TEntity entity)
        {
            _repository.Excluir(entity);
            _repository.Salvar();
        }

        public virtual void Inserir(TEntity entity)
        {
            Validar(entity);

            _repository.Inserir(entity);
            _repository.Salvar();
        }

        public virtual void Validar(TEntity entity)
        {
            var validador = new TEntityValidator();

            validador.ValidateAndThrow(entity);
        }
    }
}
