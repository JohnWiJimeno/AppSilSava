using AppSilSava.AccesoDatos.Models;
using AppSilSava.Entities;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.Repositorio.Implementaciones
{
    public class ContratoRepositorio: IContratoRepositorio
    {
        private readonly InfraCoreDbContext _bd; //variable de la base de datos

        public ContratoRepositorio(InfraCoreDbContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Contrato>> Listar()
        {
            //se conencta a la base de datos y trae la lista 
            return await _bd.Contratos.Include(p => p.EstadoContrato).Include(p => p.TipoObra).ToListAsync();
            // se incluye el estado del contrato y el tipo de obra para mostrar su nombre en la consulta

        }
    }
}
