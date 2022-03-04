using AS32.Application.Dto.Faturamento.Cadastro;
using AS32.Application.Interfaces.Faturamento.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Faturamento.Cadastro;
using AS32.Domain.Faturamento.Cadastro;
using AutoMapper;
using System.Collections.Generic;

namespace AS32.Application.Service.Faturamento.Cadastro
{
    public class ApplicationServiceEntidade : IApplicationServiceEntidade
    {
        #region Contrutores
        public ApplicationServiceEntidade(IMapper mapper, IServiceEntidade serviceEntidade)
            => (_mapper, _serviceEntidade) = (mapper, serviceEntidade);
        #endregion Contrutores

        #region Propriedades
        private readonly IServiceEntidade _serviceEntidade;
        private readonly IMapper _mapper;
        #endregion Propriedades

        #region Métodos Publicos
        public void Add(EntidadeDto entidade)
            => _serviceEntidade.Add(_mapper.Map<Entidade>(new EntidadeDto()));

        public IEnumerable<EntidadeDto> GetAll()
            => _mapper.Map<List<EntidadeDto>>(_serviceEntidade.GetAll());
        #endregion Métodos Publicos
    }
}