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
    public class EstadoContratoNegocio: IEstadoContratoNegocio
    {
        private IEstadoContratoRepositorio _repositorio;
        public EstadoContratoNegocio(IEstadoContratoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<EstadoContratoResponse>>> lista()
        {
            RepuestaBase<List<EstadoContratoResponse>> rpta = new RepuestaBase<List<EstadoContratoResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaEstado = lista.Select(p => new EstadoContratoResponse
                {
                    EstadoContratoId = p.EstadoContratoId,
                    Codigo = p.Codigo,
                    Descripcion = p.Descripcion
                }).ToList();
                rpta.Data = listaEstado;
                rpta.Exito = true;
            }
            catch (Exception ex) { 
               //rpta.Exito = false;
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
