using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.TipoObra;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ITipoObraNegocio
    {
        Task<RepuestaBase<List<TipoObraResponse>>> Listar();
    }
}
