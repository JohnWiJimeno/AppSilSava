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
    public class AnalisisTecnicoNegocio: IAnalisisTecnicoNegocio
    {
        private IAnalisisTecnicoRepositorio _repositorio;
        public AnalisisTecnicoNegocio(IAnalisisTecnicoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<AnalisisTecnicoResponse>>> Listar()
        {
            RepuestaBase<List<AnalisisTecnicoResponse>> rpta = new RepuestaBase<List<AnalisisTecnicoResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaAnalisisTecnico = lista.Select(p => new AnalisisTecnicoResponse
                {
                    LicitacionId = p.LicitacionId,
                    EmpresaId = p.EmpresaId,
                    ContratoId = p.ContratoId,
                    Observacion = p.Observacion,
                }).ToList();
                rpta.Data = listaAnalisisTecnico;
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
