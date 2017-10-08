using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkCards.Core.Entities.Interfaces;
using WorkCards.Core.Repositories.Interfaces;
using WorkCards.Infrastructure.DAL.FE;

namespace WorkCards.Infrastructure.DAL.Repository
{
    public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : class, IInternalEntity
    {
        private readonly WorkCardsContext _context;
        public WriteRepository(WorkCardsContext context)
        {
            _context = context;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAttachedAsync<TProperty>(TEntity entity, System.Linq.Expressions.Expression<Func<TEntity, TProperty>> propertySelector)
        {
            throw new NotImplementedException();
        }
    }
}
