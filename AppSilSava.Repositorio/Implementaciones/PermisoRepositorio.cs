using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class PermisoRepositorio: IPermisoRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public PermisoRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Permiso>> Listar()
        {
            //se conencta a la base de datos y trae la lista solo de los permisos activos
            return await _bd.Permisos.Where(p=>p.Activo==true).ToListAsync();
        }
    }
}