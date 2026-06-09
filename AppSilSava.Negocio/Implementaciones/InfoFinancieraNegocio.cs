using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.InfoFinanciera;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class InfoFinancieraNegocio: IInfoFinancieraNegocio
    {
        private IInfoFinancieraRepositorio _repositorio;
        public InfoFinancieraNegocio(IInfoFinancieraRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<InfoFinancieraResponse>>> listar(string empresaId)
        {
            RepuestaBase<List<InfoFinancieraResponse>> rpta = new RepuestaBase<List<InfoFinancieraResponse>>();
            try
            {
                // 1. Le pides al repositorio la lista completa (o idealmente creas un método en repositorio que filtre por query)
                var lista = await _repositorio.Listar();
                // 2. Filtramos usando .Where() para dejar únicamente los de la empresa seleccionada
                var listaFinanciera = lista.Where(p => p.EmpresaId == empresaId).Select(p => new InfoFinancieraResponse
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
                rpta.Data = listaFinanciera;
                rpta.Exito = true;
            }
            catch (Exception ex) { 
                rpta.Mensaje = ex.Message;
            
            }
            return rpta;
        }
    }
}
