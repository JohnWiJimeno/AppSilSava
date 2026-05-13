using AppSilSava.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSilSava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaldoContratoEjec5CController : ControllerBase
    {
        private readonly ISaldoContratoEjec5CNegocio _repositorio;

        public SaldoContratoEjec5CController(ISaldoContratoEjec5CNegocio repositorio)
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
