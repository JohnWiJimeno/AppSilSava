using AppSilSava.Cliente.Proxy.Interfaces;
using AppSilSava.DTO.Response.Contrato;
using AppSilSava.DTO.Response.Generic;
using System.Net.Http.Json;

namespace AppSilSava.Cliente.Proxy.implementaciones
{
    public class ContratoProxy : IContratoProxy
    {
        private HttpClient _cliente;

        public ContratoProxy(HttpClient cliente)
        {
            _cliente = cliente;
        }
        public async Task<RepuestaBase<List<ContratoResponse>>> Listar()
        {
            RepuestaBase<List<ContratoResponse>>? rpta = new RepuestaBase<List<ContratoResponse>>();
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<ContratoResponse>>>("api/Contrato") ?? new RepuestaBase<List<ContratoResponse>>();
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
