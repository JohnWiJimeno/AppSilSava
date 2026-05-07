using AppSilSava.DTO.Response.Licitacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ILicitacionNegocio
    {
        Task<List<LicitacionResponse>> Listar();
    }
}
