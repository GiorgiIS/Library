using Library.Core.Entities;
using Library.Repository.EF;
using Library.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Repository.Implementations
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context) { }
    }
}
