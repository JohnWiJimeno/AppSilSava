using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.ContratoAporte;
using AppSilSava.DTO.Response.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IContratoAporteNegocio
    {
        Task<RepuestaBase<List<ContratoAporteResponse>>> listar();
    }
}
