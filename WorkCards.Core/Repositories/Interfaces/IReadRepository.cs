using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkCards.Core.Entities.Interfaces;

namespace WorkCards.Core.Repositories.Interfaces
{
    public interface IReadRepository<TEntity> where TEntity : class, IInternalEntity
    {
        Task<TEntity> GetAsync(TEntity Entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
