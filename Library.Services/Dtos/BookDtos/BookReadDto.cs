using Library.Core.Entities;
using System;

namespace Library.Services.Dtos.BookDtos
{
    public class BookReadDto : ReadDtoBase<Book>
    {
       public string Title { get; set; }
		public string Description { get; set; }
    }
}
