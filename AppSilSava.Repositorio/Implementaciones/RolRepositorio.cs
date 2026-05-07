using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class RolRepositorio: IRolRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public RolRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Rol>> Listar()
        {
            //se conencta a la base de datos y trae la lista 
            return await _bd.Rols.ToListAsync();

        }

    }
}
