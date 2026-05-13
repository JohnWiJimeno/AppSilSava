using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ITablaSalarioNegocio
    {
        Task<RepuestaBase<List<TablaSalarioResponse>>> List();
    }
}
