using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Usuario
{
    public class UsuarioResponse
    {
        public int UsuarioId { get; set; }

        public string EmpresaId { get; set; } = null!;

        public int RolId { get; set; }

        public string NombreCompleto { get; set; } = null!;

        public string NombreUsuario { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        // public bool Activo { get; set; } / no se incluye en la respuesta, ya que no es necesario mostrarlo al cliente si esta activo

        public DateTime FechaRegistro { get; set; }

        public DateTime UltimoAcceso { get; set; }
    }
}
