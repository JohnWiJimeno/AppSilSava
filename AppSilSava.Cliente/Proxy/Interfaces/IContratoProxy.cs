using AppSilSava.DTO.Response.Contrato;
using AppSilSava.DTO.Response.Generic;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface IContratoProxy
    {
        Task<RepuestaBase<List<ContratoResponse>>> Listar();

    }
}
