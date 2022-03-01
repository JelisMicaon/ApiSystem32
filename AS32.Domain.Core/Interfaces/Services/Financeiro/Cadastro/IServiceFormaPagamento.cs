using AS32.Domain.Financeiro.Cadastro;
using System.Collections.Generic;

namespace AS32.Domain.Core.Interfaces.Services.Financeiro.Cadastro
{
    public interface IServiceFormaPagamento
    {
        void Add(FormaPagamento formaPagamento);
        IEnumerable<FormaPagamento> GetAll();
    }
}