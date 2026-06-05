using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.AnalisisFinanciero
{
    public class AnalisisFinancieroResponse
    {
        //public int AnalisisFinanId { get; set; }

        public int LicitacionId { get; set; }

        public string EmpresaId { get; set; } = null!;

        public int IndicadorId { get; set; }

        public decimal? IndiceLiquidez { get; set; }

        public decimal? IndiceEndeudamiento { get; set; }

        public decimal? RazonCobertura { get; set; }

        public decimal? CapitalTrabajo { get; set; }

        public decimal? Patrimonio { get; set; }

        public decimal? RentaPatrimonio { get; set; }

        public decimal? RentaActivo { get; set; }
    }
}
