using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Common.Api;
using Library.Common.Api.RequestModels;
using Library.Core.Entities;
using Library.Interfaces.Services;
using Library.Services.Dtos.BookDtos;
using System;
using System.Linq;

namespace Library.Api.Controllers
{
    [Route("api/authors/{authorId}/books")]
    public class BooksController : Controller
    {
        private readonly ILibraryService _libraryService;
        public BooksController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet]
        public IActionResult GetBooksForAuthor(Guid authorId)
        {
            if (!_libraryService.AuthorExists(authorId))
            {
                return NotFound();
            }

            var books = _libraryService.GetBooksByAuthorId(authorId);
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookForAuthor(Guid authorId, Guid id)
        {
            if (!_libraryService.AuthorExists(authorId))
            {
                return NotFound();
            }

            var books = _libraryService.GetBookByAuthorAndBookId(authorId, id);
            return Ok(books);
        }
    }
}
