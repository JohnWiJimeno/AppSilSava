using AppSilSava.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ITipoObraNegocio
    {
        Task<List<TipoObraResponse>> Listar();
    }
}
