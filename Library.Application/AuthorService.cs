using Library.Repository.Interfaces;
using Library.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Library.Core.Entities;
using System.Reflection;
using Library.Common;

namespace Library.Application
{
    public class AuthorService : CrudService<Author>, IAuthorService
    {
        public AuthorService(IAuthorRepository repository) : base(repository) { }
    }
}
