using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Contrato
{
    public class ContratoResponse
    {
        public int ContratoId { get; set; }

        public string? EmpresaId { get; set; }

        public int? NoRup { get; set; }

        public string? ObjetoContrato { get; set; }

        public string? EntidadContratante { get; set; }

        public string? NoContrato { get; set; }

        public string? NombreContratista { get; set; }

        public string? NitConsorcioUt { get; set; }

        public decimal? PorcentajePart { get; set; }

        public string? NombreTipoObra { get; set; } = null; // busca el nombre del tipo de obra en lugar del id para mostrarlo en la consulta

        //public int? TipoObraId { get; set; } // esta lo puedo cambiar por el nombre del tipo de obra para mostrarlo en la consulta

        public DateOnly? FechaInicio { get; set; }

        public DateOnly? FechaFinal { get; set; } 

        public decimal? Plazo { get; set; }

        public decimal? ValorContrato { get; set; }

        public decimal? VrSmmlv { get; set; }

        public decimal? VrSmmlvPart { get; set; }

        public decimal? VrTotalContrato { get; set; }

        public string? NombreEstadoContrato { get; set; } = null; // busca el nombre del estado del contrato en lugar del id para mostrarlo en la consulta

        //public int? EstadoContratoId { get; set; }

        public string? DatosTecnicos { get; set; }

        public DateOnly? FechaRut { get; set; }

        public string? Responsable { get; set; }

        public string? Telefono { get; set; }

        public string? Correo { get; set; }

        public string? Plataforma { get; set; }

        public string? LinkContrato { get; set; }

        public string? DetallesAdicionales { get; set; }

        public byte[]? DocumentoPdf { get; set; }

        public int? SalarioId { get; set; }

        public decimal? ValorSalarioActual { get; set; }
    }
}
