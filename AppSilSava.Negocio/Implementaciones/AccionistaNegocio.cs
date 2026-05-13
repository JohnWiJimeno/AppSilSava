using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class AccionistaNegocio: IAccionistaNegocio
    {
        private IAccionistaRepositorio _repositorio;
        public AccionistaNegocio(IAccionistaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<AccionistaResponse>>> Listar()
        {
            RepuestaBase<List<AccionistaResponse>> rpta = new RepuestaBase<List<AccionistaResponse>>();
              try
                {
                var lista = await _repositorio.Listar();
                var listaAccionista=lista.Select(p => new AccionistaResponse
                {
                    AccionistaId = p.AccionistaId,
                    EmpresaId = p.EmpresaId,
                    EmpresaAccionistaId = p.EmpresaAccionistaId,
                    PorcentajePart = p.PorcentajePart,
                    VrAccion = p.VrAccion,
                    NoAcciones = p.NoAcciones
                }).ToList();
                rpta.Data = listaAccionista;
                rpta.Exito = true;
              }
                catch (Exception ex)
                {
                    //rpta.Exito = false;
                    rpta.Mensaje = ex.Message;
                }
                return rpta;
            
        }

        
    }
}
