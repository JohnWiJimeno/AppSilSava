using AppSilSava.Negocio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSilSava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoController : ControllerBase
    {
        private readonly IContratoNegocio _repositorio;

        public ContratoController(IContratoNegocio repositorio)
        {
            _repositorio = repositorio;
        }
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var rpta = await _repositorio.Listar();
            return rpta.Exito ? Ok(rpta) : BadRequest(rpta);
        }

        // 👇 NUEVO ENDPOINT AÑADIDO:
        // La URL para consumirlo será: GET api/Contrato/por-empresa/{id_de_la_empresa}
        [HttpGet("por-empresa/{empresaId}")]
        public async Task<IActionResult> ListarPorEmpresa(string empresaId)
        {
            var rpta = await _repositorio.ListarPorEmpresa(empresaId);

            // Sigue tu mismo estándar: si fue exitoso devuelve Ok, si no, BadRequest con el error
            return rpta.Exito ? Ok(rpta) : BadRequest(rpta);
        }
    }

}
