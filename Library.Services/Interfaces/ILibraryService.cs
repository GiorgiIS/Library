using Library.Core.Entities;
using Library.Interfaces.Services;
using Library.Services.Dtos.AuthorDtos;
using Library.Services.Dtos.BookDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Interfaces.Services
{
    public interface ILibraryService 
    {
        List<AuthorReadDto> GetAuthors();
        AuthorReadDto GetAuthorById(Guid id);
        bool AuthorExists(Guid authorId);
        List<BookReadDto> GetBooksByAuthorId(Guid authorId);
        BookReadDto GetBookByAuthorAndBookId(Guid authorId, Guid id);
    }
}