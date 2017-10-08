using System;
using System.Collections.Generic;
using System.Text;

namespace WorkCards.DataAccess.Interfaces
{
    public interface IContextGetter
    {
        AuroraContext Context { get; }
    }
}
