using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class TipoObra
{
    public int TipoObraId { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
}
