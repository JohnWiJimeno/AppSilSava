using AppSilSava.DTO.Response.Empresa;
using AppSilSava.DTO.Response.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface IEmpresaNegocio
    {
        Task<RepuestaBase<List<EmpresaResponse>>> Listar();
    }
}
