using AS32.Domain.Faturamento.Cadastro;
using System.Collections.Generic;

namespace AS32.Domain.Core.Interfaces.Services.Faturamento.Cadastro
{
    public interface IServiceEntidade
    {
        void Add(Entidade entidade);
        IEnumerable<Entidade> GetAll();
    }
}