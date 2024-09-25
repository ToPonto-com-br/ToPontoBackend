using Microsoft.AspNetCore.Mvc;
using ToPontoBackend.Domain.Entidade;

namespace ToPontoBackend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrativoController : ControllerBase
    {

        [HttpPost]
        public IActionResult CadastroDeUsuario([FromBody] CadastroUsuario novoUsuario)
        {
            return Ok();
        }
    }
}
