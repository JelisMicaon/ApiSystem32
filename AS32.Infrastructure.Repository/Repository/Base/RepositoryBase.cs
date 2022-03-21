using AS32.Domain.Core.Interfaces.Repository.Base;
using AS32.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async virtual Task<long?> Add(T obj)
        {
            long? response = null;
            try
            {
                _context.Add(obj);
                if (await _context.SaveChangesAsync() > 0)
                    response = 1;
            }
            catch
            {
                await Dispose();
            }
            return response;
        }

        public async virtual ValueTask Dispose()
            => await _context.DisposeAsync();

        public async virtual Task<IEnumerable<T>> GetAll()
            => await _context.Set<T>().ToListAsync();

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