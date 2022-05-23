using AutoMapper;
using System.Linq.Expressions;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class GenericService<TEntity, TEntityDto> : IGenericService<TEntityDto>
        where TEntity : Entity
        where TEntityDto : EntityDto
    {
        protected IGenericRepository<TEntity> _repository;
        protected IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual TEntityDto ObterPorId(int id)
        {
            return _mapper.Map<TEntityDto>(_repository.ObterPorId(id));
        }

        public virtual TEntityDto ObterPorExpressao(Expression<Func<TEntityDto, bool>> expressao)
        {
            var expressaoEntity = _mapper.Map<Expression<Func<TEntity, bool>>>(expressao);
            return _mapper.Map<TEntityDto>(_repository.ObterPorExpressao(expressaoEntity));
        }

        public virtual IEnumerable<TEntityDto> ObterTodos()
        {
            return _mapper.Map<IEnumerable<TEntityDto>>(_repository.ObterTodos());
        }

        public virtual IEnumerable<TEntityDto> ObterTodosPorExpressao(Expression<Func<TEntityDto, bool>> expressao)
        {
            var expressaoEntity = _mapper.Map<Expression<Func<TEntity, bool>>>(expressao);
            return _mapper.Map<IEnumerable<TEntityDto>>(_repository.ObterTodosPorExpressao(expressaoEntity));
        }

        public virtual void Atualizar(TEntityDto entityDto)
        {
            var entity = _mapper.Map<TEntity>(entityDto);

            Validar(entity);

            _repository.Atualizar(entity);
            _repository.Salvar();
        }

        public virtual void Deletar(TEntityDto entityDto)
        {
            var entity = _mapper.Map<TEntity>(entityDto);

            _repository.Excluir(entity);
            _repository.Salvar();
        }

        public virtual void Inserir(TEntityDto entityDto)
        {
            var entity = _mapper.Map<TEntity>(entityDto);

            Validar(entity);

            _repository.Inserir(entity);
            _repository.Salvar();

            entityDto.Id = entity.Id;
        }

        public virtual void Validar(TEntity entity)
        {
            if (entity is not IEntityValidator) return;

            var entityValidator = entity as IEntityValidator;

            entityValidator.Validar();
        }
    }
}
