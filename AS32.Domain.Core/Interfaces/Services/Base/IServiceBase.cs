using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Domain.Core.Interfaces.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        Task<long?> Add(T entity);

        T GetById(int id);

        Task<IEnumerable<T>> GetAll();

        void Update(T entity);

        void Remove(T entity);

        ValueTask Dispose();
    }
}