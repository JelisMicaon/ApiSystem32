using AS32.Domain.Core.Interfaces.Repository.Faturamento.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Faturamento.Cadastro;
using AS32.Domain.Faturamento.Cadastro;
using AS32.Domain.Services.Services.Base;

namespace AS32.Domain.Services.Services.Faturamento.Cadastro
{
    public class ServiceEntidade : ServiceBase<Entidade>, IServiceEntidade
    {
        #region Construtores
        public ServiceEntidade(IRepositoryEntidade repository) : base(repository)
            => _repositoryEntidade = repository;
        #endregion Construtores

        #region Propriedades
        private readonly IRepositoryEntidade _repositoryEntidade;
        #endregion Propriedades

        #region Métodos Publicos
        new public void Add(Entidade entidade)
            => _repositoryEntidade.Add(entidade);
        #endregion Métodos Publicos
    }
}