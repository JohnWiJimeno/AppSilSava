using AppSilSava.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ISaldoContratoEjec5CNegocio
    {
        Task<List<SaldoContratoEjec5CResponse>> Listar();
    }
}
