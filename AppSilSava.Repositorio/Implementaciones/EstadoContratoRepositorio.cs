using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class EstadoContratoRepositorio: IEstadoContratoRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public EstadoContratoRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<EstadoContrato>> Listar()
        {
            //se conencta a la base de datos y trae la lista solo de los estados de contrato activos
            return await _bd.EstadoContratos.Where(p => p.Activo==true).ToListAsync();

        }
    }
}
 