using AS32.Application.Dto.Estoque.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Interfaces.Estoque.Cadastro
{
    public interface IApplicationServiceProduto
    {
        Task<IEnumerable<ProdutoDto>> GetAll();

        Task<ProdutoDto> Add();
    }
}