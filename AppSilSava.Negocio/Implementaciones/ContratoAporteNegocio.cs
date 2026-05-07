using AppSilSava.DTO.Response;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class ContratoAporteNegocio
    {
        private IContratoAporteRepositorio _repositorio;
        public ContratoAporteNegocio(IContratoAporteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<ContratoAporteResponse>> listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new ContratoAporteResponse
            {
                ContratoId = p.ContratoId,
                EmpresaId = p.EmpresaId,
                AccionistaId = p.AccionistaId
            }).ToList();
        }   
    }
}
