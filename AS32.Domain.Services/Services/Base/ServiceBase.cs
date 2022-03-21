using AS32.Domain.Core.Interfaces.Repository.Base;
using AS32.Domain.Core.Interfaces.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Domain.Services.Services.Base
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        #region Contrutores
        public ServiceBase(IRepositoryBase<T> repository)
            => _repository = repository;
        #endregion Contrutores

        #region Propriedades
        private readonly IRepositoryBase<T> _repository;
        #endregion Propriedades

        #region Métodos Publicos
        public async virtual Task<long?> Add(T entity)
            => await _repository.Add(entity);

        public async virtual ValueTask Dispose()
            => await _repository.Dispose();

        public async virtual Task<IEnumerable<T>> GetAll()
            => await _repository.GetAll();

        public virtual T GetById(int id)
            => _repository.GetById(id);

        public virtual void Remove(T entity)
            => _repository.Remove(entity);

        public virtual void Update(T entity)
            => _repository.Update(entity);
        #endregion Métodos Publicos
    }
}