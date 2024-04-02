using Blazored.SessionStorage;
using BlazorWasmApp.Client;
using BlazorWasmApp.Client.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using NetCore.AutoRegisterDi;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddMudServices();

InjectPatternFromAssemblies(builder, "Service");

await builder.Build().RunAsync();


void InjectPatternFromAssemblies(WebAssemblyHostBuilder builder, string pattern, params Assembly[] assembly)
{
    builder.Services.RegisterAssemblyPublicNonGenericClasses(GetAssemblies("BlazorWasmApp"))
         .Where(c => c.Name.EndsWith(pattern, StringComparison.CurrentCultureIgnoreCase))
         .AsPublicImplementedInterfaces();
}

Assembly[] GetAssemblies(string appName)
{
    return AppDomain.CurrentDomain.GetAssemblies()
        .Where(x => (x.FullName ?? string.Empty)
        .StartsWith(appName, StringComparison.CurrentCultureIgnoreCase))
        .ToArray();
}