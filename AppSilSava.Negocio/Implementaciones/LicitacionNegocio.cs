using AppSilSava.DTO.Response.Licitacion;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class LicitacionNegocio
    {
        private ILicitacionRepositorio _repositorio;
        public LicitacionNegocio(ILicitacionRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<LicitacionResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new LicitacionResponse
            {
                TipoPliegoId = p.TipoPliegoId,
                NoProceso = p.NoProceso,
                Objeto = p.Objeto,
                ValorProceso = p.ValorProceso,
                PlazoMeses = p.PlazoMeses,
                EstadoContratoId = p.EstadoContratoId,
                FechaApertura = p.FechaApertura,
                FechaCierre = p.FechaCierre,
                Smmlv = p.Smmlv,
                Kresidual = p.Kresidual,
                Anticipo = p.Anticipo,
                Patrimonio = p.Patrimonio,
                CapitalTrabajo = p.CapitalTrabajo,
                ValorSmmlv = p.ValorSmmlv,
                RelacionCv = p.RelacionCv,
                RelacionCsmmlv = p.RelacionCsmmlv,
                DiscapacitadoVr = p.DiscapacitadoVr,
                DiscapacitadoSmmlv = p.DiscapacitadoSmmlv,
                FiftyExpValor = p.FiftyExpValor,
                FiftyExpSmmlv = p.FiftyExpSmmlv,
                FechaAnalisis = p.FechaAnalisis,
                Observaciones = p.Observaciones
            }).ToList();
        }
    }
}
