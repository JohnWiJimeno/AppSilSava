using AppSilSava.DTO.Response.Empresa;
using AppSilSava.DTO.Response.Generic;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface IEmpresaProxy
    {
        Task<RepuestaBase<List<EmpresaResponse>>> Listar();
    }
}
