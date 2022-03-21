using Microsoft.AspNetCore.Mvc;

namespace AS32.Presentation.Controllers.Base
{
    public class BaseController : Controller
    {
        #region Métodos Privados
        protected ActionResult Result(object obj = null)
        {
            if (obj is null)
                return NotFound();
            else
                return Ok(obj);
        }
        #endregion Métodos Privados
    }
}