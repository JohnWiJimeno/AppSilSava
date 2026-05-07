using AppSilSava.DTO.Response;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class TipoEmpresaNegocio
    {
        private ITipoEmpresaRepositorio _repositorio;
        public TipoEmpresaNegocio(ITipoEmpresaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<TipoEmpresaResponse>> Listar()
        {
            var lista = await _repositorio.Listar();

            return lista.Select(p => new TipoEmpresaResponse
            {
                Nombre = p.Nombre,
            }).ToList();


        }
    }
}
