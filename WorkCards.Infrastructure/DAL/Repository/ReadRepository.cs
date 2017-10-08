using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkCards.Core.Entities.Interfaces;
using WorkCards.Core.Repositories.Interfaces;
using WorkCards.Infrastructure.DAL.FE;

namespace WorkCards.Infrastructure.DAL.Repository
{
    public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : class, IInternalEntity
    {
        private readonly WorkCardsContext _context;
        public ReadRepository(WorkCardsContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(TEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
