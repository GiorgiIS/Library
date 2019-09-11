using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Common.Api;
using Library.Common.Api.RequestModels;
using Library.Core.Entities;
using Library.Interfaces.Services;
using Library.Services.Dtos.BookDtos;

namespace Library.Api.Controllers
{
    [Route("Api/Book")]
    [ApiController]
    public class BookController : CrudController<Book, BookReadDto, BookCreateDto, BookUpdateDto, BookSearchQuery, IBookService>
    {
        public BookController(IBookService service, IMapper mapper) : base(service, mapper) { }
    }
}
