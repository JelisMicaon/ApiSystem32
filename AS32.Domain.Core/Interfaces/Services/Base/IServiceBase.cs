using System.Collections.Generic;

namespace AS32.Domain.Core.Interfaces.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T entity);

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Update(T entity);

        void Remove(T entity);

        void Dispose();
    }
}