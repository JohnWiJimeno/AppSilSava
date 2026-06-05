using AppSilSava.Cliente.Proxy.Interfaces;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.TipoEmpresa;
using System.Net.Http.Json;

namespace AppSilSava.Cliente.Proxy.implementaciones
{
    public class TipoEmpresaProxy : ITipoEmpresaProxy
    {
        private HttpClient _cliente;

        public TipoEmpresaProxy(HttpClient cliente)
        {
            _cliente = cliente;


        }
        public async Task<RepuestaBase<List<TipoEmpresaResponse>>> Listar()
        {
            RepuestaBase<List<TipoEmpresaResponse>>? rpta = new RepuestaBase<List<TipoEmpresaResponse>>(); // Inicializar la variable rpta para evitar el error CS8600 por ese usa ?
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<TipoEmpresaResponse>>>("api/TipoEmpresa") ?? new RepuestaBase<List<TipoEmpresaResponse>>();//rpta pude ser nula, por eso se usa el operador de fusión de null (??) para asignar un nuevo objeto RepuestaBase<List<TipoEmpresaResponse>> en caso de que sea nula.
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
