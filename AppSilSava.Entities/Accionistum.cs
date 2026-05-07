using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class Accionistum
{
    public int AccionistaId { get; set; }

    public string EmpresaId { get; set; } = null!;

    public string? EmpresaAccionistaId { get; set; }

    public string? PorcentajePart { get; set; }

    public string? VrAccion { get; set; }

    public string? NoAcciones { get; set; }

    public virtual ICollection<ContratoAporte> ContratoAportes { get; set; } = new List<ContratoAporte>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual Empresa? EmpresaAccionista { get; set; }
}
