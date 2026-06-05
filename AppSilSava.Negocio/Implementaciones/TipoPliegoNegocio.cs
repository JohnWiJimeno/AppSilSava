using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.TiploPliego;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class TipoPliegoNegocio: ITipoPliegoNegocio
    {
        private ITipoPliegoRepositorio _repositorio;
        public TipoPliegoNegocio(ITipoPliegoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<TipoPliegoResponse>>> Listar()
         {
            RepuestaBase<List<TipoPliegoResponse>> rpta = new RepuestaBase<List<TipoPliegoResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var ListaPliego = lista.Select(x => new TipoPliegoResponse
                {
                    NombreTipoPliego = x.NombreTipoPliego,
                    Descripcion = x.Descripcion
                }).ToList();
                rpta.Data = ListaPliego;
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
