using System;
using System.Collections.Generic;
using System.Text;
using WorkCards.Infrastructure.DAL.FE;

namespace WorkCards.Infrastructure.DAL.Interfaces
{
    public interface IContextGetter
    {
        WorkCardsContext Context { get; }
    }
}
