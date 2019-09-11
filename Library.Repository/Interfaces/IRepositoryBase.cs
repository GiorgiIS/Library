using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Library.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        IQueryable<T> GetAll();
        T GetById(Guid id);
        bool Exists(Guid id);
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        Guid Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Guid id);
        int SaveChanges();
    }
}
