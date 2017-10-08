using System;
using System.Collections.Generic;
using System.Text;

namespace WorkCards.Infrastructure.DAL.Entities.Interfaces
{
    public interface ILockable
    {
        bool IsLocked { get; }
        void Lock();
        void Unlock();
    }
}
