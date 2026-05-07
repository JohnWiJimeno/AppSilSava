using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class ContratoAporte
{
    public int AporteId { get; set; }

    public int ContratoId { get; set; }

    public string? EmpresaId { get; set; }

    public int? AccionistaId { get; set; }

    public virtual Accionistum? Accionista { get; set; }

    public virtual Contrato Contrato { get; set; } = null!;

    public virtual Empresa? Empresa { get; set; }
}
