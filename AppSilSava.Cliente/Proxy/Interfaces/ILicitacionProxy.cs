using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Licitacion;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface ILicitacionProxy
    {
        Task<RepuestaBase<List<LicitacionResponse>>> Listar();
    }
}
