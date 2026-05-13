using AppSilSava.DTO.Response.Contrato;
using AppSilSava.DTO.Response.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IContratoNegocio
    {
        Task<RepuestaBase<List<ContratoResponse>>> Listar();
    }
}
