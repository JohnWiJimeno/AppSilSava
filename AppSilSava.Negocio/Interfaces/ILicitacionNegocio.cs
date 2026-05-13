using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Licitacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ILicitacionNegocio
    {
        Task<RepuestaBase<List<LicitacionResponse>>> Listar();
    }
}
