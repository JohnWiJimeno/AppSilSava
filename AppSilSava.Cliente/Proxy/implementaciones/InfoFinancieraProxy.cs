using AppSilSava.Cliente.Proxy.Interfaces;
using AppSilSava.DTO.Response.Contrato;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.InfoFinanciera;
using System.Net.Http.Json;

namespace AppSilSava.Cliente.Proxy.implementaciones
{
    public class InfoFinancieraProxy: IInfoFinancieraProxy
    {
        private HttpClient _cliente;

        public InfoFinancieraProxy(HttpClient cliente)
        {
            _cliente = cliente;
        }
        public async Task<RepuestaBase<List<InfoFinancieraResponse>>> Listar(string empresaId)
        {
            RepuestaBase<List<InfoFinancieraResponse>>? rpta = new RepuestaBase<List<InfoFinancieraResponse>>();
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<InfoFinancieraResponse>>>("api/InfoFinanciera/"+ empresaId) ?? new RepuestaBase<List<InfoFinancieraResponse>>();
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
