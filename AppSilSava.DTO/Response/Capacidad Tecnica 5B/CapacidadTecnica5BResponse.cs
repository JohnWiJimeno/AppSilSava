using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.CapacidadTEcnica
{
    public class CapacidadTecnica5BResponse
    {
        public int CapacidadTecnicaId { get; set; }

        public string EmpresaId { get; set; } = null!;

        public string NombreProfesional { get; set; } = null!;

        public string Profesion { get; set; } = null!;

        public string MatriculaProfesional { get; set; } = null!;

        public string NoContrato { get; set; } = null!;

        public DateOnly FechaTerminacion { get; set; }
    }
}
