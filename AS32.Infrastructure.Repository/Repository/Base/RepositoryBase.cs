using AS32.Domain.Core.Interfaces.Repository.Base;
using AS32.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AS32.Infrastructure.Repository.Repository.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        #region Contrutores
        public RepositoryBase(SqlServerContext context)
            => _context = context;
        #endregion Contrutores

        #region Propriedades
        private readonly SqlServerContext _context;
        #endregion Propriedades

        #region Métodos Publicos
        public virtual void Add(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
            => _context.Set<T>().ToList();

        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T obj)
        {
            throw new NotImplementedException();
        }
        #endregion Métodos Publicos
    }
}