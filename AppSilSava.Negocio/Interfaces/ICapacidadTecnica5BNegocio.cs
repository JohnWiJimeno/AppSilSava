using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.CapacidadTEcnica;
using AppSilSava.DTO.Response.Contrato;
using AppSilSava.DTO.Response.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ICapacidadTecnica5BNegocio
    {
        Task<RepuestaBase<List<CapacidadTecnica5BResponse>>> Listar();
        Task<RepuestaBase<List<CapacidadTecnica5BResponse>>> ListarPorEmpresa(string empresaId);
    }
}
