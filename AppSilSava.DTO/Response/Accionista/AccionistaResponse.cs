using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Accionista
{
    public class AccionistaResponse
    {
        public int AccionistaId { get; set; }

        public string EmpresaId { get; set; } = null!;

        public string? EmpresaAccionistaId { get; set; }

        public string? PorcentajePart { get; set; }

        public string? VrAccion { get; set; }

        public string? NoAcciones { get; set; }
    }
}
