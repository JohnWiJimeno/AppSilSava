using AppSilSava.DTO.Response.Accionista;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class AccionistaNegocio
    {
        private IAccionistaRepositorio _repositorio;
        public AccionistaNegocio(IAccionistaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<AccionistaResponse>> Listar()
        {
            var lista= await _repositorio.Listar();
            return lista.Select(p=> new AccionistaResponse
            {
                AccionistaId = p.AccionistaId,
                EmpresaId = p.EmpresaId,
                EmpresaAccionistaId = p.EmpresaAccionistaId,
                PorcentajePart = p.PorcentajePart,
                VrAccion = p.VrAccion,
                NoAcciones = p.NoAcciones
            }).ToList();
        }

    }
}
