using AppSilSava.AccesoDatos.Models;
using AppSilSava.Repositorio.Implementaciones;
using AppSilSava.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<InfraCoreDbContext>(opt=>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("cn"));
});


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//registro de repositorios
builder.Services.AddScoped<IAccionistaRepositorio, AccionistaRepositorio>();
builder.Services.AddScoped<IAnalisisFinancieroRespositorio, AnalisisFinancieroRepositorio>();
builder.Services.AddScoped<IAnalisisPuntuableRepositorio, AnalisisPuntuableRepositorio>();
builder.Services.AddScoped<IAnalisisTecnicoRepositorio, AnalisisTecnicoRepositorio>();
builder.Services.AddScoped<ICapacidadTecnica5BRepositorio, CapacidadTecnica5BRepositorio>();
builder.Services.AddScoped<IContratoAporteRepositorio, ContratoAporteRepositorio>();
builder.Services.AddScoped<IContratoRepositorio, ContratoRepositorio>();
builder.Services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
builder.Services.AddScoped<IEstadoContratoRepositorio, EstadoContratoRepositorio>();
builder.Services.AddScoped<IInfoFinancieraRepositorio, InfoFinancieraRepositorio>();
builder.Services.AddScoped<ILicitacionRepositorio, LicitacionRepositorio>();
builder.Services.AddScoped<IPermisoRepositorio, PermisoRepositorio>();
builder.Services.AddScoped<IRolPermisoRepositorio, RolPermisoRepositorio>();
builder.Services.AddScoped<IRolRepositorio, RolRepositorio>();
builder.Services.AddScoped<ISaldoContratoEjec5CRepositorio, SaldoContratoEjec5CRepositorio>();
builder.Services.AddScoped<ITablaSalarioRepositorio, TablaSalarioRepositorio>();
builder.Services.AddScoped<ITipoEmpresaRepositorio, TipoEmpresaRepositorio>();
builder.Services.AddScoped<ITipoObraRepositorio, TipoObraRepositorio>();
builder.Services.AddScoped<ITipoPliegoRepositorio, TipoPliegoRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
