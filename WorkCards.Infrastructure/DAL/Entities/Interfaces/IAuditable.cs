using System;
using System.Collections.Generic;
using System.Text;

namespace WorkCards.Infrastructure.DAL.Entities
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
