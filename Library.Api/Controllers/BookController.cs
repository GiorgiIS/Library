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
        //private readonly ILibraryService _libraryService;
        //public BooksController(ILibraryService libraryService)
        //{
        //    _libraryService = libraryService;
        //}

        //[HttpGet]
        //public IActionResult GetBooksForAuthor(Guid authorId)
        //{
        //    var authors = _libraryService.Get(c => c.Id == authorId.ToString());

        //    if (!authors.Any())
        //    {
        //        return NotFound();
        //    }

        //    var books = _libraryService.GetBooksByAuthorId(authorId);
        //    return Ok(books);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetBookForAuthor(Guid authorId, Guid id)
        //{
        //    var authors = _libraryService.Get(c => c.Id == authorId.ToString());

        //    if (!authors.Any())
        //    {
        //        return NotFound();
        //    }

        //    var books = _libraryService.GetBooksByAuthorId(authorId).Where(c => c.Id == id.ToString());
        //    return Ok(books);
        //}
    }
}
