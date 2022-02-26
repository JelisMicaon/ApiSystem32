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
        public async Task<IActionResult> GetAll()
            => new JsonResult(_contexto.GetAll());

        [HttpPost]
        public async Task<IActionResult> Add()
            => new JsonResult(_contexto.Add());
        #endregion Métodos Publicos
    }
}
