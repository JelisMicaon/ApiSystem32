using AS32.Application.Dto.Faturamento.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Interfaces.Faturamento.Cadastro
{
    public interface IApplicationServiceEntidade
    {
        Task<IEnumerable<EntidadeDto>> GetAll();

        Task<long?> Add(EntidadeDto entidade);
    }
}