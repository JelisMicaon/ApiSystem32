using AS32.Application.Dto.Faturamento.Cadastro;
using AS32.Application.Interfaces.Faturamento.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Faturamento.Cadastro;
using AS32.Domain.Faturamento.Cadastro;
using System.Collections.Generic;

namespace AS32.Application.Service.Faturamento.Cadastro
{
    public class ApplicationServiceEntidade : IApplicationServiceEntidade
    {
        #region Contrutores
        public ApplicationServiceEntidade(IServiceEntidade serviceEntidade)
            => _serviceEntidade = serviceEntidade;
        #endregion Contrutores

        #region Propriedades
        private IServiceEntidade _serviceEntidade;
        #endregion Propriedades

        #region Métodos Publicos
        public void Add(EntidadeDto entidade)
            => _serviceEntidade.Add(new Entidade());

        public IEnumerable<EntidadeDto> GetAll()
        {
            var retorno = _serviceEntidade.GetAll();
            return new List<EntidadeDto>();
        }
        #endregion Métodos Publicos
    }
}