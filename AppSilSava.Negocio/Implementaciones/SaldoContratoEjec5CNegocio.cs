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
    public class SaldoContratoEjec5CNegocio: ISaldoContratoEjec5CNegocio
    {
        private ISaldoContratoEjec5CRepositorio _repositorio;
        public SaldoContratoEjec5CNegocio(ISaldoContratoEjec5CRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<SaldoContratoEjec5CResponse>>> Listar()
        {
            RepuestaBase<List<SaldoContratoEjec5CResponse>> rpta = new RepuestaBase<List<SaldoContratoEjec5CResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaSCE = lista.Select(p => new SaldoContratoEjec5CResponse
                {
                    EmpresaId = p.EmpresaId,
                    ContratoId = p.ContratoId,
                    FechaCalculo = p.FechaCalculo,
                    SaldoPendienteEjec = p.SaldoPendienteEjec,
                    FechaInicioReinicio = p.FechaInicioReinicio,
                    FechaCierreProceso = p.FechaCierreProceso,
                    DiasEjecutados = p.DiasEjecutados,
                    DiasXejecutar = p.DiasXejecutar,
                    SaldoDiarioContrato = p.SaldoDiarioContrato,
                    SaldoContratoEjec = p.SaldoContratoEjec,
                    EstadoSce = p.EstadoSce
                }).ToList();
                rpta.Data = listaSCE;
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
