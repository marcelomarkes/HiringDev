using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiYoutube.Infra.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        int Adicionar(TEntity entity);
        IEnumerable<TEntity>
            ObterPorId(Expression<Func<TEntity, bool>> predicado);
        IEnumerable<TEntity> ObterTodos();
        int Atualizar(TEntity entity);
        int Remover(TEntity entity);
    }
}
