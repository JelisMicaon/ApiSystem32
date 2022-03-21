using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Domain.Core.Interfaces.Repository.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<long?> Add(T obj);

        T GetById(int id);

        Task<IEnumerable<T>> GetAll();

        void Update(T obj);

        void Remove(T obj);

        ValueTask Dispose();
    }
}