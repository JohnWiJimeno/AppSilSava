using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class TablaSalario
{
    public int SalarioId { get; set; }

    public int Anio { get; set; }

    public decimal VrSalario { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
}
