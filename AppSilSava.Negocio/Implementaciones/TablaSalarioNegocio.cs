using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class TablaSalarioNegocio: ITablaSalarioNegocio
    {
        private ITablaSalarioRepositorio _repositorio;
        public TablaSalarioNegocio(ITablaSalarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<TablaSalarioResponse>>> List()
        {
            RepuestaBase<List<TablaSalarioResponse>> rpta = new RepuestaBase<List<TablaSalarioResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaSalario = lista.Select(p => new TablaSalarioResponse
                {
                    Anio = p.Anio,
                    VrSalario = p.VrSalario
                }).ToList();
                rpta.Data = listaSalario;
                rpta.Exito = true;

            }
            catch (Exception ex) { 
            
            rpta.Mensaje=ex.Message;
            }
            return rpta;
            }
            
    }
}
