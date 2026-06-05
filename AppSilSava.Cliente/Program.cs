using AppSilSava.Cliente;
using AppSilSava.Cliente.Proxy.implementaciones;
using AppSilSava.Cliente.Proxy.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string UrlBase = builder.Configuration.GetValue<string>("UrlAPI") ?? ""; //obtener url base del api desde appsettings.json
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(UrlBase) });//url base

//registrar proxy
builder.Services.AddScoped<IEmpresaProxy, EmpresaProxy>();
builder.Services.AddScoped<IContratoProxy, ContratoProxy>();
builder.Services.AddScoped<ITipoEmpresaProxy, TipoEmpresaProxy>();

builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
