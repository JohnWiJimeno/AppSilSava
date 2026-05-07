using AppSilSava.DTO.Response.Accionista;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IAccionistaNegocio
    {
        Task<List<AccionistaResponse>> Listar();
    }
}
