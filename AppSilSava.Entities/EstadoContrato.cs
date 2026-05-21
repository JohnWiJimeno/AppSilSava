using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class EstadoContrato
{
    public int EstadoContratoId { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Licitacion> Licitacions { get; set; } = new List<Licitacion>();

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
}
