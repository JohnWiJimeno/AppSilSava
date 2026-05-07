using AppSilSava.DTO.Response.Empresa;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IEmpresaNegocio
    {
        Task<List<EmpresaResponse>> Listar();
    }
}
