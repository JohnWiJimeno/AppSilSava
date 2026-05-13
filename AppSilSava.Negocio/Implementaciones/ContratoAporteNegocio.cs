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
    public class ContratoAporteNegocio: IContratoAporteNegocio
    {
        private IContratoAporteRepositorio _repositorio;
        public ContratoAporteNegocio(IContratoAporteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<ContratoAporteResponse>>> listar()
        {
            RepuestaBase<List<ContratoAporteResponse>> rpta = new RepuestaBase<List<ContratoAporteResponse>>();
            try 
            {
                var lista = await _repositorio.Listar();
                var listaContratoA= lista.Select(p => new ContratoAporteResponse
                {
                    ContratoId = p.ContratoId,
                    EmpresaId = p.EmpresaId,
                    AccionistaId = p.AccionistaId
                }).ToList();
                rpta.Data = listaContratoA;
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
