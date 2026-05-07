using AppSilSava.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Negocio.Interfaces
{
    public interface ICapacidadTecnica5BNegocio
    {
        Task<List<CapacidadTecnica5BResponse>> Listar();
    }
}
