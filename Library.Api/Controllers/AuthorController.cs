using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Common.Api;
using Library.Common.Api.RequestModels;
using Library.Core.Entities;
using Library.Interfaces.Services;
using Library.Services.Dtos.AuthorDtos;
using System.Collections;
using Library.Services.Dtos.BookDtos;
using Library.Application;

namespace Library.Api.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController 
    {
        private readonly ILibraryService libraryService;
        public AuthorController(ILibraryService libraryService, IMapper mapper) {

        }

    }
}
