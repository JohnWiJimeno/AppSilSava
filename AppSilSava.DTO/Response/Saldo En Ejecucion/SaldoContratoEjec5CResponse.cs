using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.SaldoContratoSCE
{
    public class SaldoContratoEjec5CResponse
    {
        //public int Sceid { get; set; }

        public string EmpresaId { get; set; } = null!;

        public int ContratoId { get; set; }

        public string? ObjetoContrato { get; set; }

        public string? EntidadContratante { get; set; }

        public string? NoContrato { get; set; }

        public decimal? PorcentajePart { get; set; }

        public decimal? Plazo { get; set; }

        public decimal? ValorContrato { get; set; }

        public DateOnly? FechaCalculo { get; set; }

        public decimal? SaldoPendienteEjec { get; set; }

        public DateOnly? FechaInicioReinicio { get; set; }

        public DateOnly? FechaCierreProceso { get; set; }

        public decimal? DiasEjecutados { get; set; }

        public decimal? DiasXejecutar { get; set; }

        public decimal? SaldoDiarioContrato { get; set; }

        public decimal? SaldoContratoEjec { get; set; }

        public string? EstadoSce { get; set; }
    }
}
