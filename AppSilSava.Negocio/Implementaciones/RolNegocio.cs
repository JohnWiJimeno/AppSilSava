using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Rol;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class RolNegocio: IRolNegocio
    {
        private IRolRepositorio _repositorio;
        
        public RolNegocio(IRolRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<RepuestaBase<List<RolResponse>>> Listar()
        {
            RepuestaBase<List<RolResponse>> rpta = new RepuestaBase<List<RolResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaRol = lista.Select(p => new RolResponse
                {
                    NombreRol = p.NombreRol,
                    Descripcion = p.Descripcion,
                    FechaRegistro = p.FechaRegistro,
                }).ToList();
                rpta.Data = listaRol;
                rpta.Exito = true;
            }
            catch (Exception ex) { 
                rpta.Mensaje = ex.Message;

            }
            return rpta;
            
        }
    }
}
