using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class Permiso
{
    public int PermisoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string NombrePermiso { get; set; } = null!;

    public string Modulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
}
