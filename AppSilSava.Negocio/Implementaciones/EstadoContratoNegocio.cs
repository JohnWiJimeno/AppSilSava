using AppSilSava.DTO.Response;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class EstadoContratoNegocio
    {
        private IEstadoContratoRepositorio _repositorio;
        public EstadoContratoNegocio(IEstadoContratoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<EstadoContratoResponse>> lista()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new EstadoContratoResponse
            {
                EstadoContratoId = p.EstadoContratoId,
                Codigo = p.Codigo,
                Descripcion = p.Descripcion
            }).ToList();
        }
    }
}
