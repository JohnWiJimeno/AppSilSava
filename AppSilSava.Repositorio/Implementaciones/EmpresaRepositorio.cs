using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public EmpresaRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Empresa>> Listar()
        {
            //se conencta a la base de datos y trae la lista 
            //return await _bd.Empresas.ToListAsync();
            //return await _bd.Contratos.Include(p => p.EstadoContrato).Include(p => p.TipoObra).ToListAsync();
            return await _bd.Empresas.Include(p => p.TipoEmpresa).ToListAsync();// <--- ¡ESTA LÍNEA ES CLAVE!.ToListAsync();
        }

    }
    
}
