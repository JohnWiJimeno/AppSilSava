using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Rol;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IRolNegocio
    {
        Task<RepuestaBase<List<RolResponse>>> Listar();
    }
}
