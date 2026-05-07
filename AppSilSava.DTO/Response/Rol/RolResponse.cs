using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Rol
{
    public class RolResponse
    {
        public string NombreRol { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

       
        public DateTime FechaRegistro { get; set; }
    }
}
