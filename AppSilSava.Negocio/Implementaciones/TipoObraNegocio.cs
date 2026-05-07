using AppSilSava.DTO.Response;
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

        public async Task<List<TipoObraResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(x => new TipoObraResponse
            {
                Codigo = x.Codigo,
                Descripcion = x.Descripcion
            }).ToList();
        }
    }
}
