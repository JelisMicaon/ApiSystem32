using AS32.Application.Interfaces.Financeiro.Cadastro;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AS32.Presentation.Controllers.Financeiro.Cadastro
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaPagamentoController : Controller
    {
        #region Contrutores
        public FormaPagamentoController(IApplicationServiceFormaPagamento contexto)
            => _contexto = contexto;
        #endregion Contrutores

        #region Propriedades
        private readonly IApplicationServiceFormaPagamento _contexto;
        #endregion Propriedades

        #region Métodos Publicos
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new JsonResult(true);
        }

        [HttpPost]
        public async Task<IActionResult> Add()
        {
            return new JsonResult(true);
        }
        #endregion Métodos Publicos
    }
}
