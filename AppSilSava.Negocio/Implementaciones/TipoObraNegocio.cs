using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.DTO.Response.TipoObra;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class TipoObraNegocio: ITipoObraNegocio
    {
        private ITipoObraRepositorio _repositorio;
        public TipoObraNegocio(ITipoObraRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<RepuestaBase<List<TipoObraResponse>>> Listar()
        {
            RepuestaBase<List<TipoObraResponse>> rpta = new RepuestaBase<List<TipoObraResponse>>();
            try {
                var lista = await _repositorio.Listar();
                var listaObra =lista.Select(x => new TipoObraResponse
                {
                    Codigo = x.Codigo,
                    Descripcion = x.Descripcion
                }).ToList();
                rpta.Data = listaObra;
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
