using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Services.Dtos
{
    public abstract class ReadDtoBase<TEntity> where TEntity : EntityBase
    {
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
