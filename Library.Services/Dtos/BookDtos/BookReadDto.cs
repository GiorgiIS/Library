using Library.Core.Entities;
using Library.Services.Dtos.AuthorDtos;
using System;

namespace Library.Services.Dtos.BookDtos
{
    public class BookReadDto : ReadDtoBase<Book>
    {
       public string Title { get; set; }
		public string Description { get; set; }
        public AuthorReadDto Author { get; set; }
    }
}
