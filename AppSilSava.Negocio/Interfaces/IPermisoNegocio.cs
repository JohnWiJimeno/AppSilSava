using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Permiso;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IPermisoNegocio
    {
        Task<RepuestaBase<List<PermisoResponse>>> Listar();
    }
}
