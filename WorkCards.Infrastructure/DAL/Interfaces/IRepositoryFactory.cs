using System;
using System.Collections.Generic;
using System.Text;
using WorkCards.Core.Entities.Interfaces;
using WorkCards.Core.Repositories.Interfaces;

namespace WorkCards.Infrastructure.DAL.Interfaces
{
    public interface IRepositoryFactory<TEntity> where TEntity : class, IInternalEntity
    {
        IReadRepository<TEntity> GetRead(IUnitOfWork unitOfWork);
        IWriteRepository<TEntity> GetWrite(IUnitOfWork unitOfWork);
    }
}
