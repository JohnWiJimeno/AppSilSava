using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.AnalisisTecnico
{
    public class AnalisisTecnicoResponse
    {
        //public int AnalisisId { get; set; }

        public int LicitacionId { get; set; }

        public string EmpresaId { get; set; } = null!;

        public int ContratoId { get; set; }

        public string? Observacion { get; set; }
    }
}
