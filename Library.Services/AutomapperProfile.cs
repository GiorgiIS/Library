using AutoMapper;
using Library.Core.Entities;
using Library.Services.Dtos.AuthorDtos;
using Library.Services.Dtos.BookDtos;

namespace Library.Services
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Author, AuthorCreateDto>().ReverseMap();
			CreateMap<Author, AuthorUpdateDto>().ReverseMap();
			CreateMap<Author, AuthorReadDto>().ReverseMap();

			CreateMap<Author, AuthorCreateDto>().ReverseMap();
			CreateMap<Author, AuthorUpdateDto>().ReverseMap();
			CreateMap<Author, AuthorReadDto>().ReverseMap();

			CreateMap<Book, BookCreateDto>().ReverseMap();
			CreateMap<Book, BookUpdateDto>().ReverseMap();
			CreateMap<Book, BookReadDto>().ReverseMap();

			CreateMap<Book, BookCreateDto>().ReverseMap();
			CreateMap<Book, BookUpdateDto>().ReverseMap();
			CreateMap<Book, BookReadDto>().ReverseMap();
        }
    }
}
