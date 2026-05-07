using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class TablaSalarioRepositorio: ITablaSalarioRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public TablaSalarioRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<TablaSalario>> Listar()
        {
            //se conencta a la base de datos y trae la lista 
            return await _bd.TablaSalarios.ToListAsync();

        }
    }
}
