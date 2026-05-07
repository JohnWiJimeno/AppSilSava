using AppSilSava.DTO.Response;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class SaldoContratoEjec5CNegocio
    {
        private ISaldoContratoEjec5CRepositorio _repositorio;
        public SaldoContratoEjec5CNegocio(ISaldoContratoEjec5CRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<SaldoContratoEjec5CResponse>> Listar()
        {
             var lista = await _repositorio.Listar();
             return lista.Select(p=> new SaldoContratoEjec5CResponse
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
        }
            
    }
}
