using AppSilSava.DTO.Response;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class CapacidadTecnica5BNegocio
    {
        private ICapacidadTecnica5BRepositorio _repositorio;
        public CapacidadTecnica5BNegocio (ICapacidadTecnica5BRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<CapacidadTecnica5BResponse>> Listar()
        {
            var lista=await _repositorio.Listar();
            return lista.Select(x => new CapacidadTecnica5BResponse
            {
                CapacidadTecnicaId = x.CapacidadTecnicaId,
                EmpresaId = x.EmpresaId,
                NombreProfesional = x.NombreProfesional,
                Profesion = x.Profesion,
                MatriculaProfesional = x.MatriculaProfesional,
                NoContrato = x.NoContrato,
                FechaTerminacion = x.FechaTerminacion
            }).ToList();

        }
    }
}
