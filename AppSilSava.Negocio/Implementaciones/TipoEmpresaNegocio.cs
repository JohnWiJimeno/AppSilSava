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
    public class TipoEmpresaNegocio: ITipoEmpresaNegocio
    {
        private ITipoEmpresaRepositorio _repositorio;
        public TipoEmpresaNegocio(ITipoEmpresaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<TipoEmpresaResponse>>> Listar()
        {
            RepuestaBase<List<TipoEmpresaResponse>> rpta = new RepuestaBase<List<TipoEmpresaResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var tipoEmpresa = lista.Select(p => new TipoEmpresaResponse
                {
                    Nombre = p.Nombre,
                }).ToList();
                rpta.Data = tipoEmpresa;
                rpta.Exito = true;
            }
            catch (Exception ex) 
            { 
            rpta.Mensaje = ex.Message;

            }
            return rpta;

        }
    }
}
