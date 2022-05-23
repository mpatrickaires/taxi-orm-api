using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TaxiOrmApi.Models;
using TaxiOrmApi.Repositories.Interfaces;

namespace TaxiOrmApi.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        private DbContext _context;
        protected DbSet<TEntity> Set;

        public GenericRepository(DbContext context)
        {
            _context = context;
            Set = _context.Set<TEntity>();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return Set.AsNoTracking().FirstOrDefault(e => e.Id == id);
        }

        public virtual TEntity ObterPorExpressao(Expression<Func<TEntity, bool>> expressao)
        {
            return Set.AsNoTracking().FirstOrDefault(expressao);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return Set.AsNoTracking().AsEnumerable();
        }

        public virtual IEnumerable<TEntity> ObterTodosPorExpressao(Expression<Func<TEntity, bool>> expressao)
        {
            return Set.AsNoTracking().Where(expressao);
        }

        public virtual void Salvar()
        {
            _context.SaveChanges();
        }

        public virtual void Inserir(TEntity entity)
        {
            _context.Add(entity);
        }

        public virtual void Atualizar(TEntity entity)
        {
            _context.Update(entity);
        }

        public virtual void Excluir(TEntity entity)
        {
            _context.Remove(entity);
        }
    }
}
