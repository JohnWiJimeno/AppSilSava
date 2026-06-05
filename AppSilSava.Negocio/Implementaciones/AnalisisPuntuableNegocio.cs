using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.AnalisisPuntuable;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class AnalisisPuntuableNegocio : IAnalisisPuntuableNegocio
    {
        private IAnalisisPuntuableRepositorio _repositorio;
        public AnalisisPuntuableNegocio(IAnalisisPuntuableRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<AnalisisPuntuableResponse>>> Listar()

        {
            RepuestaBase<List<AnalisisPuntuableResponse>> rpta = new RepuestaBase<List<AnalisisPuntuableResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaAnalisisPuntuable = lista.Select(p => new AnalisisPuntuableResponse
                {
                    LicitacionId = p.LicitacionId,
                    EmpresaId = p.EmpresaId,
                    Discapacitado = p.Discapacitado,
                    Emprendimiento = p.Emprendimiento,
                    MiPyme = p.MiPyme,
                    Observaciones = p.Observaciones,

                }).ToList();
                rpta.Data = listaAnalisisPuntuable;
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
