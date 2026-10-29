using AppSilSava.Cliente.Proxy.Interfaces;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Licitacion;
using System.Net.Http.Json;

namespace AppSilSava.Cliente.Proxy.implementaciones
{
    public class LicitacionProxy : ILicitacionProxy
    {
        private HttpClient _cliente;

        public LicitacionProxy(HttpClient cliente)
        {
            _cliente = cliente;
        }


        public async Task<RepuestaBase<List<LicitacionResponse>>> Listar()
        {
            RepuestaBase<List<LicitacionResponse>>? rpta = new RepuestaBase<List<LicitacionResponse>>();
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<LicitacionResponse>>>("api/Licitacion") ?? new RepuestaBase<List<LicitacionResponse>>();
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
