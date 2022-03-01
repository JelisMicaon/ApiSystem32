using AS32.Domain.Estoque.Cadastro;
using System.Collections.Generic;

namespace AS32.Domain.Core.Interfaces.Services.Estoque.Cadastro
{
    public interface IServiceProduto
    {
        void Add(Produto produto);
        IEnumerable<Produto> GetAll();
    }
}