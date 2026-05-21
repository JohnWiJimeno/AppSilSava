using System;
using System.Collections.Generic;

namespace AppSilSava.Entities;

public partial class Contrato
{
    public int ContratoId { get; set; }

    public string? EmpresaId { get; set; }

    public int? NoRup { get; set; }

    public string? ObjetoContrato { get; set; }

    public string? EntidadContratante { get; set; }

    public string? NoContrato { get; set; }

    public string? NombreContratista { get; set; }

    public string? NitConsorcioUt { get; set; }

    public decimal? PorcentajePart { get; set; }

    public int? TipoObraId { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFinal { get; set; }

    public decimal? Plazo { get; set; }

    public decimal? ValorContrato { get; set; }

    public decimal? VrSmmlv { get; set; }

    public decimal? VrSmmlvPart { get; set; }

    public decimal? VrTotalContrato { get; set; }

    public int? EstadoContratoId { get; set; }

    public string? DatosTecnicos { get; set; }

    public DateOnly? FechaRut { get; set; }

    public string? Responsable { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Plataforma { get; set; }

    public string? LinkContrato { get; set; }

    public string? DetallesAdicionales { get; set; }

    public byte[]? DocumentoPdf { get; set; }

    public int? SalarioId { get; set; }

    public virtual ICollection<AnalisisTecnico> AnalisisTecnicos { get; set; } = new List<AnalisisTecnico>();

    public virtual ICollection<ContratoAporte> ContratoAportes { get; set; } = new List<ContratoAporte>();

    public virtual TablaSalario? Salario { get; set; }

    public virtual ICollection<SaldoContratosEjec5C> SaldoContratosEjec5Cs { get; set; } = new List<SaldoContratosEjec5C>();

    public virtual TipoObra? TipoObra { get; set; }

    public virtual EstadoContrato? EstadoContrato { get; set; }

}
