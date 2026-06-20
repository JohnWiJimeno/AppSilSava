using AppSilSava.Cliente.Proxy.Interfaces;
using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using System.Net.Http.Json;

namespace AppSilSava.Cliente.Proxy.implementaciones
{
    public class AccionistaProxy : IAccionistaProxy
    {

        private HttpClient _cliente;

        public AccionistaProxy(HttpClient cliente)
        {
            _cliente = cliente;
        }
        public async Task<RepuestaBase<List<AccionistaResponse>>> Listar()
        {
            RepuestaBase<List<AccionistaResponse>>? rpta = new RepuestaBase<List<AccionistaResponse>>();
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<AccionistaResponse>>>("api/Accionista") ?? new RepuestaBase<List<AccionistaResponse>>();
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
