using AS32.Domain.Core.Interfaces.Repository.Financeiro.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Financeiro.Cadastro;
using AS32.Domain.Financeiro.Cadastro;
using AS32.Domain.Services.Services.Base;

namespace AS32.Domain.Services.Services.Financeiro.Cadastro
{
    public class ServiceFormaPagamento : ServiceBase<FormaPagamento>, IServiceFormaPagamento
    {
        #region Construtores
        public ServiceFormaPagamento(IRepositoryFormaPagamento repository) : base(repository)
            => _repositoryFormaPagamento = repository;
        #endregion Construtores

        #region Propriedades
        private readonly IRepositoryFormaPagamento _repositoryFormaPagamento;
        #endregion Propriedades
    }
}