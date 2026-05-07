using AppSilSava.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Interfaces
{
    public interface IContratoRepositorio
    {
        Task<List<Contrato>> Listar();
    }
}
