using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.SaldoContratoSCE;

namespace AppSilSava.Cliente.Proxy.Interfaces
{
    public interface ISaldoContratoEjec5CProxy
    {
        Task<RepuestaBase<List<SaldoContratoEjec5CResponse>>> Listar();
    }
}
