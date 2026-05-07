using AppSilSava.DTO.Response;
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
        public async Task<List<TipoPliegoResponse>> Listar()
         {
            var lista = await _repositorio.Listar();
            return lista.Select(x => new TipoPliegoResponse
            {
                NombreTipoPliego = x.NombreTipoPliego,
                Descripcion = x.Descripcion
            }).ToList();
        }
    }
}
