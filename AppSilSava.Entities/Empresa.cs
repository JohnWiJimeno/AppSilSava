using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class Empresa
{
    public string EmpresaId { get; set; } = null!;

    public string? RazonSocial { get; set; }

    public string? Sigla { get; set; }

    public string? Departamento { get; set; }

    public string? Ciudad { get; set; }

    public string? MatriculaNo { get; set; }

    public DateOnly? FechaMatricula { get; set; }

    public string? DireccionDomiclio { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? TamanoEmpresa { get; set; }

    public string? NombreRepLegal { get; set; }

    public string? IdentificacionRl { get; set; }

    public string? NombreSuplente { get; set; }

    public string? IdentificacionS { get; set; }

    public string? RevisorFiscal { get; set; }

    public string? IdentificacionRf { get; set; }

    public bool? Discapacitado { get; set; }

    public bool? EmpredimientoMujer { get; set; }

    public bool? Mipyme { get; set; }

    public byte[]? Logo { get; set; }

    public int? TipoEmpresaId { get; set; }

    public virtual ICollection<Accionistum> AccionistumEmpresaAccionista { get; set; } = new List<Accionistum>();

    public virtual ICollection<Accionistum> AccionistumEmpresas { get; set; } = new List<Accionistum>();

    public virtual ICollection<AnalisisFinanciero> AnalisisFinancieros { get; set; } = new List<AnalisisFinanciero>();

    public virtual ICollection<AnalisisTecnico> AnalisisTecnicos { get; set; } = new List<AnalisisTecnico>();

    public virtual ICollection<CapacidadTecnica5B> CapacidadTecnica5Bs { get; set; } = new List<CapacidadTecnica5B>();

    public virtual ICollection<ContratoAporte> ContratoAportes { get; set; } = new List<ContratoAporte>();

    public virtual ICollection<InfoFinanciera> InfoFinancieras { get; set; } = new List<InfoFinanciera>();

    public virtual ICollection<SaldoContratosEjec5C> SaldoContratosEjec5Cs { get; set; } = new List<SaldoContratosEjec5C>();

    public virtual TipoEmpresa? TipoEmpresa { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
