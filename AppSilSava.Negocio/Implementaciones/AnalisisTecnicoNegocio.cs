using AppSilSava.DTO.Response;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class AnalisisTecnicoNegocio: IAnalisisTecnicoNegocio
    {
        private IAnalisisTecnicoRepositorio _repositorio;
        public AnalisisTecnicoNegocio(IAnalisisTecnicoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<AnalisisTecnicoResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new AnalisisTecnicoResponse
            {
                LicitacionId = p.LicitacionId,
                EmpresaId = p.EmpresaId,
                ContratoId = p.ContratoId,
                Observacion = p.Observacion,
            }).ToList();
        }
    }
}
