using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.EmpresaCombo
{
    public class EmpresaComboResponse
    {
        public string EmpresaId { get; set; } = null!;
        public string? NombreTipoEmpresa { get; set; }  // busca el nombre del tipo de empresa en lugar del id para mostrarlo en la consulta
    }
}
