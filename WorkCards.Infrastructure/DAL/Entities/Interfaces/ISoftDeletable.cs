using System;
using System.Collections.Generic;
using System.Text;

namespace WorkCards.Infrastructure.DAL.Entities.Interfaces
{
    public interface ISoftDeletable
    {
        bool IsActive { get; }
        void Delete();
    }
}
