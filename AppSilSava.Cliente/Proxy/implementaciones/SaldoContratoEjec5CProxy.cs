using AppSilSava.Cliente.Proxy.Interfaces;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.SaldoContratoSCE;
using System.Net.Http.Json;

namespace AppSilSava.Cliente.Proxy.implementaciones
{
    public class SaldoContratoEjec5CProxy : ISaldoContratoEjec5CProxy
    {
        private readonly HttpClient _cliente;

        public SaldoContratoEjec5CProxy(HttpClient cliente)
        {
            _cliente = cliente;
        }

        public async Task<RepuestaBase<List<SaldoContratoEjec5CResponse>>> Listar()
        {
            RepuestaBase<List<SaldoContratoEjec5CResponse>>? rpta = new RepuestaBase<List<SaldoContratoEjec5CResponse>>();
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<SaldoContratoEjec5CResponse>>>("api/SaldoContratoEjec5C") ?? new RepuestaBase<List<SaldoContratoEjec5CResponse>>();
                return rpta;
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
                rpta.Exito = false;
            }
            return rpta;
        }

    }
}
