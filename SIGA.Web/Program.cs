using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using SIGA.IoC.Web.Setup;
using SIGA.Web;
using SIGA.Web.Security;
using SIGA.Web.Security.Interfaces;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddTransient<CookieHandler>();
builder.Services.AddMudServices();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped(x => (ICustomAuthStateProvider)x.GetRequiredService<AuthenticationStateProvider>());
builder.Services
    .AddHttpClient("siga", sp => { sp.BaseAddress = new Uri("http://localhost:5072"); })
    .AddHttpMessageHandler<CookieHandler>();

builder.Services.AddIoCHandles();


builder.Services.AddLocalization();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pt-BR");

await builder.Build().RunAsync();
