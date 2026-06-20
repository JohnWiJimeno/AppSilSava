using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface IAccionistaProxy
    {
        Task<RepuestaBase<List<AccionistaResponse>>> Listar();

    }
}
