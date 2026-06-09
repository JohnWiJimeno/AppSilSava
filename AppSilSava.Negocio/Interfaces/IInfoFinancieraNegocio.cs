using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.InfoFinanciera;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IInfoFinancieraNegocio
    {
        Task<RepuestaBase<List<InfoFinancieraResponse>>> listar(string empresaId);
    }
}
