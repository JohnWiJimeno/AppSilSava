using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IUsuarioNegocio
    {
        Task<RepuestaBase<List<UsuarioResponse>>> Listar();
    }
}
