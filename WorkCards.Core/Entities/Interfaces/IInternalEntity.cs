using System;
using System.Collections.Generic;
using System.Text;

namespace WorkCards.Core.Entities.Interfaces
{
    public interface IInternalEntity
    {

    }

    public interface IInternalEntity<TKey> : IInternalEntity
    {
        TKey Id { get; set; }
    }
}
