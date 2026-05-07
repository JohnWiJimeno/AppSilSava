using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class Rol
{
    public int RolId { get; set; }

    public string NombreRol { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
