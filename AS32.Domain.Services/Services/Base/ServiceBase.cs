using AS32.Domain.Core.Interfaces.Repository.Base;
using AS32.Domain.Core.Interfaces.Services.Base;
using System.Collections.Generic;

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
        public virtual void Add(T entity)
            => _repository.Add(entity);

        public virtual void Dispose()
            => _repository.Dispose();

        public virtual IEnumerable<T> GetAll()
            => _repository.GetAll();

        public virtual T GetById(int id)
            => _repository.GetById(id);

        public virtual void Remove(T entity)
            => _repository.Remove(entity);

        public virtual void Update(T entity)
            => _repository.Update(entity);
        #endregion Métodos Publicos
    }
}