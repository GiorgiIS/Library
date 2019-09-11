using Library.Core.Entities;
using System;

namespace Library.Services.Dtos.AuthorDtos
{
    public class AuthorCreateDto : CreateDtoBase<Author>
    {
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfbirth { get; set; }
		public string Genre { get; set; }
    }
}