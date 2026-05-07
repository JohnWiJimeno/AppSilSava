using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class TipoEmpresa
{
    public int TipoEmpresaId { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
