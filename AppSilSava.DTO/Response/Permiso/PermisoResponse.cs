using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Permiso
{
    public class PermisoResponse
    {
        public string Codigo { get; set; } = null!;

        public string NombrePermiso { get; set; } = null!;

        public string Modulo { get; set; } = null!;

        public string Descripcion { get; set; } = null!;
    }
}
