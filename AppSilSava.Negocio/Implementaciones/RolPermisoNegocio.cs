using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.RolPermiso;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class RolPermisoNegocio: IRolPermisoNegocio
    {
        private IRolPermisoRepositorio _repositorio;
        public RolPermisoNegocio(IRolPermisoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<RolPermisoResponse>>> Listar()
        {
            RepuestaBase<List<RolPermisoResponse>> rpta = new RepuestaBase<List<RolPermisoResponse>>();
            try 
            {
                var lista = await _repositorio.Listar();
                var listaRolP= lista.Select(p => new RolPermisoResponse
                {
                    RolId = p.RolId,
                    PermisoId = p.PermisoId,
                    FechaAsignacion = p.FechaAsignacion
                }).ToList();
                rpta.Data = listaRolP;
                rpta.Exito = true;
            }

            catch (Exception ex) {

                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
