using AppSilSava.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSilSava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoAporteController : ControllerBase
    {
        private readonly IContratoAporteNegocio _repositorio;

        public ContratoAporteController(IContratoAporteNegocio repositorio)
        {
            _repositorio = repositorio;
        }
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var rpta = await _repositorio.listar();
            return Ok(rpta);
        }

    }
}
