using AppSilSava.DTO.Response.Empresa;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class EmpresaNegocio
    {
        private IEmpresaRepositorio _repositorio;
        public EmpresaNegocio(IEmpresaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<EmpresaResponse>> Listar()
        {
            var lista=await _repositorio.Listar();
            return lista.Select(p=> new EmpresaResponse
            {
                EmpresaId = p.EmpresaId,
                RazonSocial = p.RazonSocial,
                Sigla = p.Sigla,
                Departamento = p.Departamento,
                Ciudad = p.Ciudad,
                MatriculaNo = p.MatriculaNo,
                FechaMatricula = p.FechaMatricula,
                DireccionDomiclio = p.DireccionDomiclio,
                Correo = p.Correo,
                Telefono = p.Telefono,
                TamanoEmpresa = p.TamanoEmpresa,
                NombreRepLegal = p.NombreRepLegal,
                IdentificacionRl = p.IdentificacionRl,
                NombreSuplente = p.NombreSuplente,
                IdentificacionS = p.IdentificacionS,
                RevisorFiscal = p.RevisorFiscal,
                IdentificacionRf = p.IdentificacionRf,
                Discapacitado = p.Discapacitado,
                EmpredimientoMujer = p.EmpredimientoMujer,
                Mipyme = p.Mipyme,
                Logo = p.Logo,
                TipoEmpresaId = p.TipoEmpresaId
            }).ToList();
        }
    }
}
