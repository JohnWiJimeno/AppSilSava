using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.SaldoContratoSCE;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ISaldoContratoEjec5CNegocio
    {
        Task<RepuestaBase<List<SaldoContratoEjec5CResponse>>> Listar();
    }
}
