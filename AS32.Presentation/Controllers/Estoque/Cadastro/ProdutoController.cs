using AS32.Application.Interfaces.Estoque.Cadastro;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AS32.Presentation.Controllers.Estoque.Cadastro
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        #region Contrutores
        public ProdutoController(IApplicationServiceProduto contexto)
            => _contexto = contexto;
        #endregion Contrutores

        #region Propriedades
        private readonly IApplicationServiceProduto _contexto;
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
