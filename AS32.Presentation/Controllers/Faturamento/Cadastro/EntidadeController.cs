using AS32.Application.Interfaces.Faturamento.Cadastro;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AS32.Presentation.Controllers.Faturamento.Cadastro
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<IActionResult> GetAll()
            => new JsonResult(_contexto.GetAll());

        [HttpPost]
        public async Task<IActionResult> Add()
            => new JsonResult(_contexto.Add());
        #endregion Métodos Publicos
    }
}