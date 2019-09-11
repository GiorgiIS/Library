using Library.Repository.Interfaces;
using Library.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Library.Core.Entities;
using System.Reflection;
using Library.Common;
using Library.Services.Dtos.BookDtos;
using AutoMapper;
using Library.Services.Dtos.AuthorDtos;

namespace Library.Application
{
    public class LibraryService : ILibraryService
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;

        public LibraryService(IBookRepository bookRepository, IAuthorRepository authorRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public List<AuthorReadDto> GetAuthors()
        {
            var authors = _authorRepository.GetAll();
            return _mapper.Map<List<AuthorReadDto>>(authors.ToList());
        }

        public AuthorReadDto GetAuthorById(Guid id)
        {
            return _mapper.Map<AuthorReadDto>(_authorRepository.GetById(id));
        }

        public bool AuthorExists(Guid authorId)
        {
            return _authorRepository.Exists(authorId);
        }

        public List<BookReadDto> GetBooksByAuthorId(Guid authorId)
        {
            return _mapper.Map<List<BookReadDto>>(_authorRepository.GetById(authorId).Books.ToList());
        }

        public BookReadDto GetBookByAuthorAndBookId(Guid authorId, Guid id)
        {
            return _mapper.Map<BookReadDto>(_authorRepository.GetById(authorId).Books.FirstOrDefault(c => c.Id == id));
        }
    }
}
