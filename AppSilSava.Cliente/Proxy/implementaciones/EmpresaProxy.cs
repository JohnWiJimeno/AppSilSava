using AppSilSava.Cliente.Proxy.Interfaces;
using AppSilSava.DTO.Response.Empresa;
using AppSilSava.DTO.Response.Generic;
using System.Net.Http.Json;

namespace AppSilSava.Cliente.Proxy.implementaciones
{
    public class EmpresaProxy : IEmpresaProxy
    {
        private HttpClient _cliente;

        public EmpresaProxy(HttpClient cliente)
        {
            _cliente = cliente;


        }
        public async Task<RepuestaBase<List<EmpresaResponse>>> Listar()
        {
            RepuestaBase<List<EmpresaResponse>>? rpta = new RepuestaBase<List<EmpresaResponse>>(); // Inicializar la variable rpta para evitar el error CS8600 por ese usa ?
            try
            {
                rpta = await _cliente.GetFromJsonAsync<RepuestaBase<List<EmpresaResponse>>>("api/Empresa") ?? new RepuestaBase<List<EmpresaResponse>>();//rpta pude ser nula, por eso se usa el operador de fusión de null (??) para asignar un nuevo objeto RepuestaBase<List<EmpresaResponse>> en caso de que sea nula.
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
