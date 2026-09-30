using AppSilSava.Cliente;
using AppSilSava.Cliente.Proxy.implementaciones;
using AppSilSava.Cliente.Proxy.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//string UrlBase = builder.Configuration.GetValue<string>("UrlAPI") ?? ""; //obtener url base del api desde appsettings.json
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(UrlBase) });//url base


// URL base del API:
// - Si "UrlAPI" tiene valor (appsettings.Development.json, cuando corres el cliente por separado en local), usa esa.
// - Si está vacía (publicado en Somee), usa la misma dirección del sitio, porque la API y el cliente están juntos.
string? UrlBase = builder.Configuration.GetValue<string>("UrlAPI");
if (string.IsNullOrWhiteSpace(UrlBase))
{
    UrlBase = builder.HostEnvironment.BaseAddress;
}
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(UrlBase) });//url base


//registrar proxy
builder.Services.AddScoped<IEmpresaProxy, EmpresaProxy>();
builder.Services.AddScoped<IContratoProxy, ContratoProxy>();
builder.Services.AddScoped<ITipoEmpresaProxy, TipoEmpresaProxy>();
builder.Services.AddScoped<IInfoFinancieraProxy, InfoFinancieraProxy>();
builder.Services.AddScoped<IAccionistaProxy, AccionistaProxy>();
builder.Services.AddScoped<ICapacidadTecnica5BProxy, CapacidadTecnica5BProxy>();
builder.Services.AddScoped<ISaldoContratoEjec5CProxy, SaldoContratoEjec5CProxy>();


builder.Services.AddMudServices();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
