using AppSilSava.DTO.Response.InfoFinanciera;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class InfoFinancieraNegocio
    {
        private IInfoFinancieraRepositorio _repositorio;
        public InfoFinancieraNegocio(IInfoFinancieraRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<InfoFinancieraResponse>> listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p=> new InfoFinancieraResponse
            {
                EmpresaId = p.EmpresaId,
                AnioFiscal = p.AnioFiscal,
                ActivoCorriente = p.ActivoCorriente,
                ActivoTotal = p.ActivoTotal,
                PasivoCorriente = p.PasivoCorriente,
                PasivoTotal = p.PasivoTotal,
                Patrimonio = p.Patrimonio,
                IngresosOperacionales = p.IngresosOperacionales,
                UtilidadPerdida = p.UtilidadPerdida,
                GastosInteres = p.GastosInteres,
                CapitalTrabajo = p.CapitalTrabajo,
                IndiceLiquidez = p.IndiceLiquidez,
                IndiceEndeudamiento = p.IndiceEndeudamiento,
                RazonCobertura = p.RazonCobertura,
                RentaPatrimonio = p.RentaPatrimonio,
                RentaActivo = p.RentaActivo
            }).ToList();
        }
    }
}
