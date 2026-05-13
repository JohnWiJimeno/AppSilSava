using AppSilSava.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSilSava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoFinancieraController : ControllerBase
    {
        private readonly IInfoFinancieraNegocio _repositorio;

        public InfoFinancieraController(IInfoFinancieraNegocio repositorio)
        {
            _repositorio = repositorio;
        }
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var rpta = await _repositorio.listar();
            return rpta.Exito ? Ok(rpta) : BadRequest(rpta);
        }
    }
}
