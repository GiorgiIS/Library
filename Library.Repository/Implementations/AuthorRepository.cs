using Library.Core.Entities;
using Library.Repository.EF;
using Library.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Repository.Implementations
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryDbContext context) : base(context) { }
    }
}
