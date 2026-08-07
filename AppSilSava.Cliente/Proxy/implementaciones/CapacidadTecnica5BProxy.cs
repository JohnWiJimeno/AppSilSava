
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.CapacidadTEcnica;
using System.Net.Http.Json;
using AppSilSava.Cliente.Proxy.Interfaces;

namespace AppSilSava.Cliente.Proxy.implementaciones
{

    public class CapacidadTecnica5BProxy : ICapacidadTecnica5BProxy
    {
        private readonly HttpClient _cliente;
        public CapacidadTecnica5BProxy(HttpClient cliente)
        {
            _cliente = cliente;
        }
        public async Task<RepuestaBase<List<CapacidadTecnica5BResponse>>> Listar()
        {
            RepuestaBase<List<CapacidadTecnica5BResponse>>? rpta = new RepuestaBase<List<CapacidadTecnica5BResponse>>();
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<CapacidadTecnica5BResponse>>>("api/CapacidadTecnica5B") ?? new RepuestaBase<List<CapacidadTecnica5BResponse>>();
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
