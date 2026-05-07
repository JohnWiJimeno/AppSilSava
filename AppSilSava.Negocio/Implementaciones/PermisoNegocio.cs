using AppSilSava.DTO.Response.Permiso;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class PermisoNegocio
    {
        private IPermisoRepositorio _repositorio;
        public PermisoNegocio(IPermisoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<PermisoResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p=> new PermisoResponse
            {
               Codigo=p.Codigo,
               NombrePermiso=p.NombrePermiso,
               Modulo=p.Modulo,
               Descripcion=p.Descripcion

            }).ToList();
        }
    }
}
