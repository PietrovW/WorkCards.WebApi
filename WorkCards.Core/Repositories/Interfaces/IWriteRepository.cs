using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkCards.Core.Entities.Interfaces;

namespace WorkCards.Core.Repositories.Interfaces
{
    public interface IWriteRepository<TEntity> where TEntity : class, IInternalEntity
    {
        Task UpdateAttachedAsync<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> propertySelector);
        Task<TEntity> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}
