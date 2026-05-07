using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string EmpresaId { get; set; } = null!;

    public int RolId { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime UltimoAcceso { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual Rol Rol { get; set; } = null!;
}
