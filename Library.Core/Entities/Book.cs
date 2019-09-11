using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Entities
{
    public class Book : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
