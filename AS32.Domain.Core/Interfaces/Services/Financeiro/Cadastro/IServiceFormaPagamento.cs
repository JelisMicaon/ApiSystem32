using AS32.Domain.Financeiro.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Domain.Core.Interfaces.Services.Financeiro.Cadastro
{
    public interface IServiceFormaPagamento
    {
        Task<long?> Add(FormaPagamento formaPagamento);
        Task<IEnumerable<FormaPagamento>> GetAll();
    }
}