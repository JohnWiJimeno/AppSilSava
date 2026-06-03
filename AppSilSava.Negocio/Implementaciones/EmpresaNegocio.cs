using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Empresa;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class EmpresaNegocio: IEmpresaNegocio
    {
        private IEmpresaRepositorio _repositorio;
        public EmpresaNegocio(IEmpresaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<EmpresaResponse>>> Listar()
        {
            RepuestaBase<List<EmpresaResponse>> rpta = new RepuestaBase<List<EmpresaResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                //var ListaEmpresa= lista.Select(p => new EmpresaResponse

                // ORDENAMIENTO: Ordenamos de forma ascendente por el Nit/CC (EmpresaId)
                var listaOrdenada = lista.OrderByDescending(p => p.EmpresaId).ToList();

                // Mapeamos desde la lista que ya se encuentra perfectamente ordenada
                var ListaEmpresa = listaOrdenada.Select(p => new EmpresaResponse

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
                    NombreTipoEmpresa = p.TipoEmpresa?.Nombre
                }).ToList();
                rpta.Data = ListaEmpresa;
                rpta.Exito = true;
            }
            catch (Exception ex) {
                rpta.Mensaje = ex.Message;

            }
            return rpta;
        }
    }
}
