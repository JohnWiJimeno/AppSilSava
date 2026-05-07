using AppSilSava.DTO.Response;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class AnalisisFinancieroNegocio
    {
        private IAnalisisFinancieroRespositorio _repositorio;
        public AnalisisFinancieroNegocio(IAnalisisFinancieroRespositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<AnalisisFinancieroResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new AnalisisFinancieroResponse
            { 
                LicitacionId=p.LicitacionId,
                EmpresaId=p.EmpresaId,
                IndicadorId=p.IndicadorId,
                IndiceLiquidez=p.IndiceLiquidez,
                RazonCobertura=p.RazonCobertura,
                CapitalTrabajo=p.CapitalTrabajo,
                Patrimonio=p.Patrimonio,
                RentaPatrimonio=p.RentaPatrimonio,
                RentaActivo=p.RentaActivo,

            }).ToList();
    }
    }
}
