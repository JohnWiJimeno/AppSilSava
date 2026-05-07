using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class CapacidadTecnica5B
{
    public int CapacidadTecnicaId { get; set; }

    public string EmpresaId { get; set; } = null!;

    public string NombreProfesional { get; set; } = null!;

    public string Profesion { get; set; } = null!;

    public string MatriculaProfesional { get; set; } = null!;

    public string NoContrato { get; set; } = null!;

    public DateOnly FechaTerminacion { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;
}
