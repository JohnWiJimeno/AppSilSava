using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class CapacidadTecnica5BRepositorio : ICapacidadTecnica5BRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public CapacidadTecnica5BRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<CapacidadTecnica5B>> Listar()
        {
            //se conencta a la base de datos y trae la lista 
            //return await _bd.CapacidadTecnica5Bs.ToListAsync();
            return await _bd.CapacidadTecnica5Bs.Include(p => p.Empresa).ToListAsync();
        }

        public async Task<List<CapacidadTecnica5B>> ListarPorEmpresa(string empresaId)
        {

            return await _bd.CapacidadTecnica5Bs
                .Include(p => p.Empresa)
                .Where(p => p.EmpresaId == empresaId)
                .ToListAsync();
        }
    }
   
}
                