using AppSilSava.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Interfaces
{
    public interface ITipoPliegoRepositorio
    {
        Task<List<TipoPliego>> Listar();
    }
}
