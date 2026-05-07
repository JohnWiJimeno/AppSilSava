using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Empresa
{
    public class EmpresaResponse
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
    }
}
