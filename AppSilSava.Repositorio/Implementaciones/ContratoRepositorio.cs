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

        // 👇 NUEVO MÉTODO AÑADIDO:
        public async Task<List<Contrato>> ListarPorEmpresa(string empresaId)
        {
            // Se conecta a la BD, incluye las relaciones y filtra por EmpresaId antes de traer los datos
            return await _bd.Contratos
                .Include(p => p.EstadoContrato)
                .Include(p => p.TipoObra)
                .Include(p=>p.Salario) // 👈 Incluimos la relación con Salario para mostrar su información
                .Where(p => p.EmpresaId == empresaId
                 && p.Salario != null
                 && p.Salario.Anio == DateTime.Now.Year) // 👈 2. Filtramos en SQL por el año actual
        .ToListAsync();
        }

    }
}
