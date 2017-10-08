using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WorkCards.Core.Entities.Interfaces;
using WorkCards.Infrastructure.DAL.Entities.Interfaces;

namespace WorkCards.Infrastructure.DAL.Entities
{
    public abstract class InternalEntity : Core.Entities.Interfaces.IInternalEntity<int>, ISoftDeletable, IAuditable
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; private set; }

        public InternalEntity()
        {
            this.IsActive = true;
        }

        void ISoftDeletable.Delete()
        {
            this.IsActive = false;
        }
    }
}
