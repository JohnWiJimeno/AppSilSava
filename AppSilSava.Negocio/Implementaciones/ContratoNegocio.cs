using AppSilSava.DTO.Response.Accionista;
using AppSilSava.DTO.Response.Contrato;
using AppSilSava.DTO.Response.Generic;
using AppSilSava.Negocio.Interfaces;
using AppSilSava.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Implementaciones
{
    public class ContratoNegocio: IContratoNegocio
    {
        private IContratoRepositorio _repositorio;
        public ContratoNegocio(IContratoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RepuestaBase<List<ContratoResponse>>> Listar()
        {
            RepuestaBase<List<ContratoResponse>> rpta = new RepuestaBase<List<ContratoResponse>>();
            try
            {
                var lista = await _repositorio.Listar();
                var listaContrato= lista.Select(p => new ContratoResponse
                {
                    EmpresaId = p.EmpresaId,
                    NoRup = p.NoRup,
                    ObjetoContrato = p.ObjetoContrato,
                    EntidadContratante = p.EntidadContratante,
                    NoContrato = p.NoContrato,
                    NombreContratista = p.NombreContratista,
                    NitConsorcioUt = p.NitConsorcioUt,
                    PorcentajePart = p.PorcentajePart,
                    TipoObraId = p.TipoObraId,
                    FechaInicio = p.FechaInicio,
                    FechaFinal = p.FechaFinal,
                    Plazo = p.Plazo,
                    ValorContrato = p.ValorContrato,
                    VrSmmlv = p.VrSmmlv,
                    VrSmmlvPart = p.VrSmmlvPart,
                    VrTotalContrato = p.VrTotalContrato,
                    EstadoContratoId = p.EstadoContratoId,
                    DatosTecnicos = p.DatosTecnicos,
                    FechaRut = p.FechaRut,
                    Responsable = p.Responsable,
                    Telefono = p.Telefono,
                    Correo = p.Correo,
                    Plataforma = p.Plataforma,
                    LinkContrato = p.LinkContrato,
                    DetallesAdicionales = p.DetallesAdicionales,
                    DocumentoPdf = p.DocumentoPdf,
                    SalarioId = p.SalarioId
                }).ToList();
                rpta.Data = listaContrato;
                rpta.Exito = true;
            }
            catch (Exception ex)
            {
                rpta.Mensaje = ex.Message;
            }
            return rpta;
        }
    }
}
