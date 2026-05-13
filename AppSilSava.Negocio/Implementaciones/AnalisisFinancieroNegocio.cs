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
    public class AnalisisFinancieroNegocio : IAnalisisFinancieroNegocio
    {
        private IAnalisisFinancieroRespositorio _repositorio;
        public AnalisisFinancieroNegocio(IAnalisisFinancieroRespositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<RepuestaBase<List<AnalisisFinancieroResponse>>> Listar()
        {
            RepuestaBase<List<AnalisisFinancieroResponse>> rpta = new RepuestaBase<List<AnalisisFinancieroResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaAnalisisFinanciero = lista.Select(p => new AnalisisFinancieroResponse
                {
                    LicitacionId = p.LicitacionId,
                    EmpresaId = p.EmpresaId,
                    IndicadorId = p.IndicadorId,
                    IndiceLiquidez = p.IndiceLiquidez,
                    RazonCobertura = p.RazonCobertura,
                    CapitalTrabajo = p.CapitalTrabajo,
                    Patrimonio = p.Patrimonio,
                    RentaPatrimonio = p.RentaPatrimonio,
                    RentaActivo = p.RentaActivo,

                }).ToList();
                rpta.Data = listaAnalisisFinanciero;
                rpta.Exito = true;
            }

            catch (Exception ex) 
            {
               
                rpta.Mensaje = ex.Message;

            }
            return rpta;




        }
    }
}
