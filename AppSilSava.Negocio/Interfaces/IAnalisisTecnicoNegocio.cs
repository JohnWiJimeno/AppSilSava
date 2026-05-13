using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IAnalisisTecnicoNegocio
    {
        Task<RepuestaBase<List<AnalisisTecnicoResponse>>> Listar();
    }
}
