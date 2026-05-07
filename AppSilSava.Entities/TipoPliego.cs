using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class TipoPliego
{
    public int TipoPliegoId { get; set; }

    public string NombreTipoPliego { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual Licitacion? Licitacion { get; set; }
}
