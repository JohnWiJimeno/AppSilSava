using AppSilSava.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Interfaces
{
    public interface ISaldoContratoEjec5CRepositorio
    {
        Task<List<SaldoContratosEjec5C>> Listar();

        // NUEVO METODO AÑADIDO:
        Task<List<SaldoContratosEjec5C>> ListarPorCSE(string empresaId);
    }
}
