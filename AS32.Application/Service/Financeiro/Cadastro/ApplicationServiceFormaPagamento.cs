using AS32.Application.Dto.Financeiro.Cadastro;
using AS32.Application.Interfaces.Financeiro.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Financeiro.Cadastro;
using AS32.Domain.Financeiro.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Service.Financeiro.Cadastro
{
    public class ApplicationServiceFormaPagamento : IApplicationServiceFormaPagamento
    {
        #region Contrutores
        public ApplicationServiceFormaPagamento(IServiceFormaPagamento serviceFormaPagamento)
            => _serviceFormaPagamento = serviceFormaPagamento;
        #endregion Contrutores

        #region Propriedades
        private IServiceFormaPagamento _serviceFormaPagamento;
        #endregion Propriedades

        #region Métodos Publicos
        public async Task<FormaPagamentoDto> Add()
        {
            _serviceFormaPagamento.Add(new FormaPagamento());
            return new FormaPagamentoDto();
        }

        public async Task<IEnumerable<FormaPagamentoDto>> GetAll()
        {
            var retorno = _serviceFormaPagamento.GetAll();
            return new List<FormaPagamentoDto>();
        }
        #endregion Métodos Publicos
    }
}