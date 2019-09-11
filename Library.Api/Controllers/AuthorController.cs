using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Common.Api;
using Library.Common.Api.RequestModels;
using Library.Core.Entities;
using Library.Interfaces.Services;
using Library.Services.Dtos.AuthorDtos;

namespace Library.Api.Controllers
{
    [Route("Api/Author")]
    [ApiController]
    public class AuthorController : CrudController<Author, AuthorReadDto, AuthorCreateDto, AuthorUpdateDto, AuthorSearchQuery, IAuthorService>
    {
        public AuthorController(IAuthorService service, IMapper mapper) : base(service, mapper) { }
    }
}
