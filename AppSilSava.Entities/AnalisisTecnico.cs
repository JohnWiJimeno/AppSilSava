using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class AnalisisTecnico
{
    public int AnalisisId { get; set; }

    public int LicitacionId { get; set; }

    public string EmpresaId { get; set; } = null!;

    public int ContratoId { get; set; }

    public string? Observacion { get; set; }

    public virtual Contrato Contrato { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual Licitacion Licitacion { get; set; } = null!;
}
