using AppSilSava.DTO.Response.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IUsuarioNegocio
    {
        Task<List<UsuarioResponse>> Listar();
    }
}
