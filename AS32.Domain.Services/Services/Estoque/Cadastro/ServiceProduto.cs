using AS32.Domain.Core.Interfaces.Repository.Estoque.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Estoque.Cadastro;
using AS32.Domain.Estoque.Cadastro;
using AS32.Domain.Services.Services.Base;

namespace AS32.Domain.Services.Services.Estoque.Cadastro
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        #region Construtores
        public ServiceProduto(IRepositoryProduto repository) : base(repository)
            => _repositoryProduto = repository;
        #endregion Construtores

        #region Propriedades
        private readonly IRepositoryProduto _repositoryProduto;
        #endregion Propriedades
    }
}