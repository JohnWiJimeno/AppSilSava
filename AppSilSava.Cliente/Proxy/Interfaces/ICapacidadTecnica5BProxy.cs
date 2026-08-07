using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.CapacidadTEcnica;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface ICapacidadTecnica5BProxy
    {
        Task<RepuestaBase<List<CapacidadTecnica5BResponse>>> Listar();
    }
}
