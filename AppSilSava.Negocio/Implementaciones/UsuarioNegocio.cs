using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.Usuario;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class UsuarioNegocio: IUsuarioNegocio
    {
        private IUsuarioRepositorio _repositorio;
        public UsuarioNegocio(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<RepuestaBase<List<UsuarioResponse>>> Listar()
        {
            RepuestaBase<List<UsuarioResponse>> rpta = new RepuestaBase<List<UsuarioResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaUsuario = lista.Select(x => new UsuarioResponse
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
                rpta.Data = listaUsuario;
                rpta.Exito = true;
            }
            catch (Exception ex) 
            { 
            rpta.Mensaje=ex.Message;
            }
            return rpta;
        }
    }
}
