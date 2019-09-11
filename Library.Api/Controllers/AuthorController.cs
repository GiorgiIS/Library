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
using System;

namespace Library.Api.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private readonly ILibraryService _libraryService;
        public AuthorsController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            return Ok(_libraryService.GetAuthors());
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthors(Guid id)
        {
            return Ok(_libraryService.GetAuthorById(id));
        }
    }
}
