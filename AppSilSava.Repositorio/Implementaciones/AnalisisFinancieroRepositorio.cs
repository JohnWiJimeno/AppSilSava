using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class AnalisisFinancieroRepositorio : IAnalisisFinancieroRespositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public AnalisisFinancieroRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<AnalisisFinanciero>> Listar()
        {
            return await _bd.AnalisisFinancieros.ToListAsync();


        }


    }
}
