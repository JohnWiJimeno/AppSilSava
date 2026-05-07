using AppSilSava.DTO.Response;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class AnalisisPuntuableNegocio
    {
        private IAnalisisPuntuableRepositorio _repositorio;
        public AnalisisPuntuableNegocio(IAnalisisPuntuableRepositorio repositorio)
        {
            _repositorio = repositorio;
        }   
         public async Task<List<AnalisisPuntuableResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new AnalisisPuntuableResponse
            { 
               LicitacionId = p.LicitacionId,
                EmpresaId = p.EmpresaId,
                Discapacitado = p.Discapacitado,
                Emprendimiento = p.Emprendimiento,
                MiPyme = p.MiPyme,
                Observaciones = p.Observaciones,

            }).ToList();
        }
    }
}