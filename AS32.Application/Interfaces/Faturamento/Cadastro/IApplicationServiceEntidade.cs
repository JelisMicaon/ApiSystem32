using AS32.Application.Dto.Faturamento.Cadastro;
using System.Collections.Generic;

namespace AS32.Application.Interfaces.Faturamento.Cadastro
{
    public interface IApplicationServiceEntidade
    {
        IEnumerable<EntidadeDto> GetAll();

        void Add(EntidadeDto entidade);
    }
}