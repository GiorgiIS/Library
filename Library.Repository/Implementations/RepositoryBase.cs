using Microsoft.EntityFrameworkCore;
using Library.Common;
using Library.Core.Entities;
using Library.Repository.EF;
using Library.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Library.Repository.Implementations
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly LibraryDbContext _context;
        public RepositoryBase(LibraryDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }

        public Guid Create(T entity)
        {
            var res = _context.Set<T>().Add(entity);
            return res.Entity.Id;
        }

        public void Update(T entity)
        {
            entity.UpdatedAt = DateTimeHelper.DateTimeNow();
            var res = _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            entity.DeletedAt = DateTimeHelper.DateTimeNow();
            entity.UpdatedAt= DateTimeHelper.DateTimeNow();
            var res = _context.Set<T>().Update(entity);
        }

        public void Delete(Guid id)
        {
            var entity = Get(c => c.Id == id).FirstOrDefault();
            entity.DeletedAt = DateTimeHelper.DateTimeNow();
            var res = _context.Set<T>().Update(entity);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
