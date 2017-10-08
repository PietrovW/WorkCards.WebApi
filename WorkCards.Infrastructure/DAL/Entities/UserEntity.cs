using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WorkCards.Infrastructure.DAL.Entities.Interfaces;

namespace WorkCards.Infrastructure.DAL.Entities
{
    [Table("Users", Schema = "usr")]
    public class UserEntity : IdentityUser, IInternalEntity<string>, ISoftDeletable, ILockable
    {
        public UserEntity()
        {
            this.IsActive = true;
            this.IsLocked = false;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; private set; }

        public bool IsLocked { get; private set; }

        public byte[] Gravatar { get; set; }
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void ILockable.Lock()
        {
            this.IsLocked = true;
        }

        void ILockable.Unlock()
        {
            this.IsLocked = false;
        }

        void ISoftDeletable.Delete()
        {
            this.IsActive = false;
        }
    }
}
