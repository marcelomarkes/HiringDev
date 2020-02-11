using ApiYoutube.Context;
using ApiYoutube.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiYoutube.Infra.Repository
{
    public class RepositoryBasic<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ApiYoutubeContext _context;

        public RepositoryBasic(ApiYoutubeContext context)
        {
            _context = context;
        }

        public int Atualizar(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return _context.SaveChanges();
        }

        public int Adicionar(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }

        public int Remover(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<TEntity> ObterPorId(Expression<Func<TEntity, bool>> predicado)
        {
            return this._context.Set<TEntity>().Where(predicado).ToList();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return this._context.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
