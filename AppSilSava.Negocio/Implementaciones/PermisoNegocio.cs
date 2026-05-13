using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Permiso;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class PermisoNegocio: IPermisoNegocio
    {
        private IPermisoRepositorio _repositorio;
        public PermisoNegocio(IPermisoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<PermisoResponse>>> Listar()
        {
            RepuestaBase<List<PermisoResponse>> rpta = new RepuestaBase<List<PermisoResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var ListaPermiso =lista.Select(p => new PermisoResponse
                {
                    Codigo = p.Codigo,
                    NombrePermiso = p.NombrePermiso,
                    Modulo = p.Modulo,
                    Descripcion = p.Descripcion

                }).ToList();
                rpta.Data = ListaPermiso;
                rpta.Exito = true;

            }
            catch (Exception ex) { 
            
            rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
