using AS32.Application.Dto.Financeiro.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Interfaces.Financeiro.Cadastro
{
    public interface IApplicationServiceFormaPagamento
    {
        Task<IEnumerable<FormaPagamentoDto>> GetAll();

        Task<FormaPagamentoDto> Add();
    }
}