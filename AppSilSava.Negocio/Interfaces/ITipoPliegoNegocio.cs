using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.TiploPliego;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ITipoPliegoNegocio
    {
        Task<RepuestaBase<List<TipoPliegoResponse>>> Listar();
    }
}
