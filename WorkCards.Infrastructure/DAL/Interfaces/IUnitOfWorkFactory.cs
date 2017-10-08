using System;
using System.Collections.Generic;
using System.Text;

namespace WorkCards.Infrastructure.DAL.Interfaces
{
    public interface IUnitOfWorkFactory<out TUnitOfWork>
    {
        TUnitOfWork Get(bool isReadOnly = true);
    }

    public interface IUnitOfWorkFactory : IUnitOfWorkFactory<IUnitOfWork>
    {
    }
}
