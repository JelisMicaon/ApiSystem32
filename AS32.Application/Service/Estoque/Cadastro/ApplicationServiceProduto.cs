using AS32.Application.Dto.Estoque.Cadastro;
using AS32.Application.Interfaces.Estoque.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Estoque.Cadastro;
using AS32.Domain.Estoque.Cadastro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Application.Service.Estoque.Cadastro
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        #region Contrutores
        public ApplicationServiceProduto(IServiceProduto serviceProduto)
            => _serviceProduto = serviceProduto;
        #endregion Contrutores

        #region Propriedades
        private IServiceProduto _serviceProduto;
        #endregion Propriedades

        #region Métodos Publicos
        public async Task<ProdutoDto> Add()
        {
            _serviceProduto.Add(new Produto());
            return new ProdutoDto();
        }

        public async Task<IEnumerable<ProdutoDto>> GetAll()
        {
            var retorno = _serviceProduto.GetAll();
            return new List<ProdutoDto>();
        }
        #endregion Métodos Publicos
    }
}