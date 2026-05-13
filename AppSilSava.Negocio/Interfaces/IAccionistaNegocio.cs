using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IAccionistaNegocio
    {
        Task<RepuestaBase<List<AccionistaResponse>>> Listar();
    }
}
