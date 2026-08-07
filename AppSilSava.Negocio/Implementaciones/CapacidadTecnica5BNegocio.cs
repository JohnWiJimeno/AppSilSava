using AppSilSava.DTO.Response;
using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.CapacidadTEcnica;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class CapacidadTecnica5BNegocio: ICapacidadTecnica5BNegocio
    {
        private ICapacidadTecnica5BRepositorio _repositorio;
        public CapacidadTecnica5BNegocio (ICapacidadTecnica5BRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<RepuestaBase<List<CapacidadTecnica5BResponse>>> Listar()
        {
            RepuestaBase<List<CapacidadTecnica5BResponse>> rpta = new RepuestaBase<List<CapacidadTecnica5BResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaCSE= lista.Select(x => new CapacidadTecnica5BResponse
                {
                    CapacidadTecnicaId = x.CapacidadTecnicaId,
                    
                    //EmpresaId = x.EmpresaId,
                    NombreEmpresa = x.Empresa.RazonSocial,
                    NombreProfesional = x.NombreProfesional,
                    Profesion = x.Profesion,
                    MatriculaProfesional = x.MatriculaProfesional,
                    NoContrato = x.NoContrato,
                    FechaTerminacion = x.FechaTerminacion
                }).ToList();
                rpta.Data = listaCSE;
                rpta.Exito = true;

            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }

        // Método 2: EL MÉTODO QUE FALTABA PARA CUMPLIR CON LA INTERFAZ
        public async Task<RepuestaBase<List<CapacidadTecnica5BResponse>>> ListarPorEmpresa(string empresaId)
        {
            RepuestaBase<List<CapacidadTecnica5BResponse>> rpta = new RepuestaBase<List<CapacidadTecnica5BResponse>>();
            try
            {
                // Aquí asumo que tu repositorio tiene un método llamado ListarPorEmpresa que recibe el string
                var lista = await _repositorio.ListarPorEmpresa(empresaId);
                var listaCSE = lista.Select(x => new CapacidadTecnica5BResponse
                {
                    CapacidadTecnicaId = x.CapacidadTecnicaId,
                    //EmpresaId = x.EmpresaId,
                    NombreEmpresa = x.Empresa?.RazonSocial, // Se añade '?' por seguridad en caso de que Empresa sea null
                    NombreProfesional = x.NombreProfesional,
                    Profesion = x.Profesion,
                    MatriculaProfesional = x.MatriculaProfesional,
                    NoContrato = x.NoContrato,
                    FechaTerminacion = x.FechaTerminacion
                }).ToList();

                rpta.Data = listaCSE;
                rpta.Exito = true;
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
                rpta.Exito = false;
            }
            return rpta;
        }
    }
}
