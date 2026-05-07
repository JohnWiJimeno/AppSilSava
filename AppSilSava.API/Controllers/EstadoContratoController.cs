using AppSilSava.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSilSava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoContratoController : ControllerBase
    {
        private readonly IEstadoContratoNegocio _repositorio;

        public EstadoContratoController(IEstadoContratoNegocio repositorio)
        {
            _repositorio = repositorio;
        }
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var rpta = await _repositorio.lista();
            return Ok(rpta);
        }
    }
}
