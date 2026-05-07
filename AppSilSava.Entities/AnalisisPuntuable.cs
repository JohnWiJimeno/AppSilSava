using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class AnalisisPuntuable
{
    public int AnalisisPid { get; set; }

    public int LicitacionId { get; set; }

    public int EmpresaId { get; set; }

    public string? Discapacitado { get; set; }

    public string? Emprendimiento { get; set; }

    public string? MiPyme { get; set; }

    public string? Observaciones { get; set; }

    public virtual Licitacion Licitacion { get; set; } = null!;
}
