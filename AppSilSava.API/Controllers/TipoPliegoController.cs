using AppSilSava.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSilSava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPliegoController : ControllerBase
    {
        private readonly ITipoPliegoNegocio _repositorio;

        public TipoPliegoController(ITipoPliegoNegocio repositorio)
        {
            _repositorio = repositorio;
        }
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var rpta = await _repositorio.Listar();
            return rpta.Exito ? Ok(rpta) : BadRequest(rpta);
        }
    }
}
