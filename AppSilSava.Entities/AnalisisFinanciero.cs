using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class AnalisisFinanciero
{
    public int AnalisisFinanId { get; set; }

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

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual InfoFinanciera Indicador { get; set; } = null!;

    public virtual Licitacion Licitacion { get; set; } = null!;
}
