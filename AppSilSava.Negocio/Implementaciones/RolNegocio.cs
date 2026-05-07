using AppSilSava.DTO.Response.Rol;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class RolNegocio
    {
        private IRolRepositorio _repositorio;
        
        public RolNegocio(IRolRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<RolResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new RolResponse
            {
                NombreRol = p.NombreRol,
                Descripcion = p.Descripcion,
                FechaRegistro = p.FechaRegistro,
            }).ToList();
        }
    }
}
