using AppSilSava.DTO.Response;
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
        public async Task<List<RolPermisoResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new RolPermisoResponse
            {
                RolId = p.RolId,
                PermisoId = p.PermisoId,
                FechaAsignacion = p.FechaAsignacion
            }).ToList();
        }
    }
}
