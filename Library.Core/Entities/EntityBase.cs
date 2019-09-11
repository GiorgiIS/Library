using Library.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Entities
{
    public abstract class EntityBase
    {
        // todo: make all properties protected and test
        public EntityBase()
        {
            CreatedAt = DateTimeHelper.DateTimeNow();
            UpdatedAt = DateTimeHelper.DateTimeNow();
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
