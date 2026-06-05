using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.TipoEmpresa;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface ITipoEmpresaProxy
    {
        Task<RepuestaBase<List<TipoEmpresaResponse>>> Listar();
    }
}
