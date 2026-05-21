using AppSilSava.AccesoDatos.Models;
using AppSilSava.Negocio.Implementaciones;
using AppSilSava.Repositorio.Implementaciones;
using AppSilSava.Repositorio.Interfaces;
using AppSilSava.Negocio.Interfaces;
using Microsoft.EntityFrameworkCore;
using AppSilSava.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<InfraCoreDbContext>(opt=>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("cn"));
});



builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());// Agregar el convertidor para DateOnly
    });

builder.Services.AddEndpointsApiExplorer(); //registar api
builder.Services.AddSwaggerGen(); //registar swagger

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
//registro de los modelos de negocio
builder.Services.AddScoped<IAccionistaNegocio, AccionistaNegocio>();
builder.Services.AddScoped<IAnalisisFinancieroNegocio, AnalisisFinancieroNegocio>();
builder.Services.AddScoped<IAnalisisPuntuableNegocio, AnalisisPuntuableNegocio>();
builder.Services.AddScoped<IAnalisisTecnicoNegocio, AnalisisTecnicoNegocio>();
builder.Services.AddScoped<ICapacidadTecnica5BNegocio, CapacidadTecnica5BNegocio>();
builder.Services.AddScoped<IContratoAporteNegocio, ContratoAporteNegocio>();
builder.Services.AddScoped<IContratoNegocio, ContratoNegocio>();
builder.Services.AddScoped<IEmpresaNegocio, EmpresaNegocio>();
builder.Services.AddScoped<IEstadoContratoNegocio, EstadoContratoNegocio>();
builder.Services.AddScoped<IInfoFinancieraNegocio, InfoFinancieraNegocio>();
builder.Services.AddScoped<ILicitacionNegocio, LicitacionNegocio>();
builder.Services.AddScoped<IPermisoNegocio, PermisoNegocio>();
builder.Services.AddScoped<IRolPermisoNegocio, RolPermisoNegocio>();
builder.Services.AddScoped<IRolNegocio, RolNegocio>();
builder.Services.AddScoped<ISaldoContratoEjec5CNegocio, SaldoContratoEjec5CNegocio>();
builder.Services.AddScoped<ITablaSalarioNegocio, TablaSalarioNegocio>();
builder.Services.AddScoped<ITipoEmpresaNegocio, TipoEmpresaNegocio>();
builder.Services.AddScoped<ITipoObraNegocio, TipoObraNegocio>();
builder.Services.AddScoped<ITipoPliegoNegocio, TipoPliegoNegocio>();
builder.Services.AddScoped<IUsuarioNegocio, UsuarioNegocio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(); // para ver la api visualmente
}

app.UseAuthorization();

app.MapControllers();

app.Run();
