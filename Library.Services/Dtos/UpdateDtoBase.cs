using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Services.Dtos
{
    public abstract class UpdateDtoBase<TEntity> where TEntity : EntityBase
    {
        public string Id { get; set; }
    }
}
