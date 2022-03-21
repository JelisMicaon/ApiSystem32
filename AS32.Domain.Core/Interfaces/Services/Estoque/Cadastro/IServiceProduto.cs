using AS32.Domain.Estoque.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Domain.Core.Interfaces.Services.Estoque.Cadastro
{
    public interface IServiceProduto
    {
        Task<long?> Add(Produto produto);
        Task<IEnumerable<Produto>> GetAll();
    }
}