using AppSilSava.DTO.Response;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class TablaSalarioNegocio: ITablaSalarioNegocio
    {
        private ITablaSalarioRepositorio _repositorio;
        public TablaSalarioNegocio(ITablaSalarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<TablaSalarioResponse>> List()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new TablaSalarioResponse
            {
                Anio = p.Anio,
                VrSalario = p.VrSalario
            }).ToList();
        }
    }
}
