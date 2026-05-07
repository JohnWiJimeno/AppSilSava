using AppSilSava.DTO.Response.Usuario;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class UsuarioNegocio
    {
        private IUsuarioRepositorio _repositorio;
        public UsuarioNegocio(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<UsuarioResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(x => new UsuarioResponse
            {
               UsuarioId = x.UsuarioId,
               EmpresaId = x.EmpresaId,
               RolId = x.RolId,
               NombreCompleto = x.NombreCompleto,
               NombreUsuario = x.NombreUsuario,
               Correo = x.Correo,
               PasswordHash = x.PasswordHash,
               FechaRegistro = x.FechaRegistro,
               UltimoAcceso = x.UltimoAcceso,
            }).ToList();
        }
    }
}
