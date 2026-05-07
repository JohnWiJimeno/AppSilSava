using AppSilSava.DTO.Response.InfoFinanciera;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IInfoFinancieraNegocio
    {
        Task<List<InfoFinancieraResponse>> listar();
    }
}
