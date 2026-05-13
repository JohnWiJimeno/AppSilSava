using AppSilSava.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSilSava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapacidadTecnica5BController : ControllerBase
    {
        private readonly ICapacidadTecnica5BNegocio _repositorio;

        public CapacidadTecnica5BController(ICapacidadTecnica5BNegocio repositorio)
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
