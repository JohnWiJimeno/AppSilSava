using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.RolPermiso;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IRolPermisoNegocio
    {
        Task<RepuestaBase<List<RolPermisoResponse>>> Listar();
    }
}
