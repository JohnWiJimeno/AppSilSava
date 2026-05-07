using AppSilSava.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ITipoPliegoNegocio
    {
        Task<List<TipoPliegoResponse>> Listar();
    }
}
