using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Licitacion
{
    public class LicitacionResponse
    {
        //public int LicitacionId { get; set; }

        public int TipoPliegoId { get; set; }

        public string? NoProceso { get; set; }

        public string? Objeto { get; set; }

        public decimal? ValorProceso { get; set; }

        public int? PlazoMeses { get; set; }

        public int? EstadoContratoId { get; set; }

        public DateOnly? FechaApertura { get; set; }

        public DateOnly? FechaCierre { get; set; }

        public decimal? Smmlv { get; set; }

        public decimal? Kresidual { get; set; }

        public decimal? Anticipo { get; set; }

        public decimal? Patrimonio { get; set; }

        public decimal? CapitalTrabajo { get; set; }

        public decimal? ValorSmmlv { get; set; }

        /// <summary>
        /// Aca se almacena la realacion de contratos si es el 75%, 120% o 150%  en salarios
        /// </summary>
        public decimal? RelacionCv { get; set; }

        /// <summary>
        /// Relacion de contratos en salarios
        /// </summary>
        public decimal? RelacionCsmmlv { get; set; }

        public decimal? DiscapacitadoVr { get; set; }

        public decimal? DiscapacitadoSmmlv { get; set; }

        public decimal? FiftyExpValor { get; set; }

        public decimal? FiftyExpSmmlv { get; set; }

        public DateOnly? FechaAnalisis { get; set; }

        public string? Observaciones { get; set; }
    }
}
