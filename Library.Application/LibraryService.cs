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
      


    }
}
