using AS32.Application.Dto.Estoque.Cadastro;
using AS32.Application.Interfaces.Estoque.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Service.Estoque.Cadastro
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        public async Task<ProdutoDto> Add()
            => new ProdutoDto();

        public async Task<IEnumerable<ProdutoDto>> GetAll()
            => new List<ProdutoDto>();
    }
}