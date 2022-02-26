using AS32.Application.Dto.Faturamento.Cadastro;
using AS32.Application.Interfaces.Faturamento.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Service.Faturamento.Cadastro
{
    public class ApplicationServiceEntidade : IApplicationServiceEntidade
    {
        public async Task<EntidadeDto> Add()
            => new EntidadeDto();

        public async Task<IEnumerable<EntidadeDto>> GetAll()
            => new List<EntidadeDto>();
    }
}