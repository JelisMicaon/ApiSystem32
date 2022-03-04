using AS32.Application.Interfaces.Faturamento.Cadastro;
using Microsoft.AspNetCore.Mvc;

namespace AS32.Presentation.Controllers.Faturamento.Cadastro
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntidadeController : Controller
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
        public IActionResult GetAll()
            => new JsonResult(_contexto.GetAll());

        [HttpPost]
        public void Add()
            => _contexto.Add();
        #endregion Métodos Publicos
    }
}