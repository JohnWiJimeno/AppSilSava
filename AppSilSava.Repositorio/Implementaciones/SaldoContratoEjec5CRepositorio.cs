using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class SaldoContratoEjec5CRepositorio: ISaldoContratoEjec5CRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public SaldoContratoEjec5CRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<SaldoContratosEjec5C>> Listar()
        {
            //se conencta a la base de datos y trae la lista 
            // CORREGIDO: sin .Include(Contrato), p.Contrato llegaba null al Negocio y
            // NoContrato, ObjetoContrato, Plazo, etc. salían vacíos. EF no carga relaciones solo.
            return await _bd.SaldoContratosEjec5Cs
                .Include(x => x.Contrato)
                .ToListAsync();
        }

        //NUEVO METODO AÑADIDO:
        public async Task<List<SaldoContratosEjec5C>> ListarPorCSE(string empresaId)
        {
            // Se conecta a la BD y filtra por ContratoId antes de traer los datos
            return await _bd.SaldoContratosEjec5Cs
                .Include(x => x.Empresa)
                .Include(x => x.Contrato)
                .Where(x => x.EmpresaId == empresaId)
                .ToListAsync();
        }



    }
}
