using AppSilSava.DTO.Response.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IContratoNegocio
    {
        Task<List<ContratoResponse>> Listar();
    }
}
