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
        [HttpGet("{empresaId}")]// Cambia la ruta para incluir el ID de la empresa como parte de la URL
        public async Task<IActionResult> Listar(string empresaId) // Recibe el ID de la empresa como parámetro de consulta
        {
            var rpta = await _repositorio.listar(empresaId); // Llama al método listar del repositorio pasando el ID de la empresa
            return rpta.Exito ? Ok(rpta) : BadRequest(rpta);
        }
    }
}
