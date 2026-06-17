using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.InfoFinanciera;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface IInfoFinancieraProxy
    {
        Task<RepuestaBase<List<InfoFinancieraResponse>>> Listar(string empresaId);
    }
}
