using AS32.Application.Dto.Financeiro.Cadastro;
using AS32.Application.Interfaces.Financeiro.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Service.Financeiro.Cadastro
{
    public class ApplicationServiceFormaPagamento : IApplicationServiceFormaPagamento
    {
        public async Task<FormaPagamentoDto> Add()
            => new FormaPagamentoDto();

        public async Task<IEnumerable<FormaPagamentoDto>> GetAll()
            => new List<FormaPagamentoDto>();
    }
}