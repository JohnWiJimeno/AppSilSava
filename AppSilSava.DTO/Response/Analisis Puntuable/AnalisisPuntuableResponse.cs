using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.AnalisisPuntuable
{
    public class AnalisisPuntuableResponse
    {
        //public int AnalisisPid { get; set; }

        public int LicitacionId { get; set; }

        public int EmpresaId { get; set; }

        public string? Discapacitado { get; set; }

        public string? Emprendimiento { get; set; }

        public string? MiPyme { get; set; }

        public string? Observaciones { get; set; }
    }
}
