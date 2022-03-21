using AS32.Application.Dto.Base;
using AS32.Application.Dto.Faturamento.Cadastro;
using AS32.Application.Interfaces.Faturamento.Cadastro;
using AS32.Presentation.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AS32.Presentation.Controllers.Faturamento.Cadastro
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntidadeController : BaseController
    {
        #region Contrutores
        public EntidadeController(IApplicationServiceEntidade contexto)
            => _contexto = contexto;
        #endregion Contrutores

        #region Propriedades
        private readonly IApplicationServiceEntidade _contexto;
        #endregion Propriedades

        #region Métodos Publicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntidadeDto>>> GetAll()
            => Result(await _contexto.GetAll());

        [HttpPost]
        public async Task<ActionResult<EntityBase>> Add(EntidadeDto entidade)
        {
            long? idProduct = await _contexto.Add(entidade);
            if (idProduct is not null)
                return Result(new EntityBase() { Id = Convert.ToInt64(idProduct) });
            else
                return Result();
        }
        #endregion Métodos Publicos
    }
}