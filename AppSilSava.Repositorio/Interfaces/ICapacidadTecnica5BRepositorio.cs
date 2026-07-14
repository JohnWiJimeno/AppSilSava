using AppSilSava.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Interfaces
{
    public interface ICapacidadTecnica5BRepositorio
    {
        Task<List<CapacidadTecnica5B>> Listar();

        Task<List<CapacidadTecnica5B>> ListarPorEmpresa(string empresaId);
    }
}
