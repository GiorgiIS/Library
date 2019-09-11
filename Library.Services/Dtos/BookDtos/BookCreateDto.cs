using Library.Core.Entities;
using System;

namespace Library.Services.Dtos.BookDtos
{
    public class BookCreateDto : CreateDtoBase<Book>
    {
        public string Title { get; set; }
		public string Description { get; set; }
    }
}