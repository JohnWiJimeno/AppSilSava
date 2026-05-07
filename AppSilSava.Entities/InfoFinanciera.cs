using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class InfoFinanciera
{
    public int IndicadorId { get; set; }

    public string EmpresaId { get; set; } = null!;

    public int AnioFiscal { get; set; }

    public decimal? ActivoCorriente { get; set; }

    public decimal? ActivoTotal { get; set; }

    public decimal? PasivoCorriente { get; set; }

    public decimal? PasivoTotal { get; set; }

    public decimal? Patrimonio { get; set; }

    public decimal? IngresosOperacionales { get; set; }

    public decimal? UtilidadPerdida { get; set; }

    public decimal? GastosInteres { get; set; }

    public decimal? CapitalTrabajo { get; set; }

    public decimal? IndiceLiquidez { get; set; }

    public decimal? IndiceEndeudamiento { get; set; }

    public decimal? RazonCobertura { get; set; }

    public decimal? RentaPatrimonio { get; set; }

    public decimal? RentaActivo { get; set; }

    public virtual ICollection<AnalisisFinanciero> AnalisisFinancieros { get; set; } = new List<AnalisisFinanciero>();

    public virtual Empresa Empresa { get; set; } = null!;
}
