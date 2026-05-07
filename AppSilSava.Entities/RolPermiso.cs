using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class RolPermiso
{
    public int RolPermisoId { get; set; }

    public int RolId { get; set; }

    public int PermisoId { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public virtual Permiso Permiso { get; set; } = null!;

    public virtual Rol Rol { get; set; } = null!;
}
