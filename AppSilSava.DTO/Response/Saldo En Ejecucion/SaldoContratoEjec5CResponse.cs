using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response
{
    public class SaldoContratoEjec5CResponse
    {
        //public int Sceid { get; set; }

        public string EmpresaId { get; set; } = null!;

        public int ContratoId { get; set; }

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
