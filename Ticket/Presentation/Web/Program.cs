using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddCors(corsOptions =>
//{
//    corsOptions.AddDefaultPolicy(corsPolicyBuilder =>
//    {
//        corsPolicyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//    });
//});

//builder.Services.AddTransient<interface, class> ();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOidcAuthentication(options =>
{
    // Configure your authentication provider options here.
    // For more information, see https://aka.ms/blazor-standalone-auth
    builder.Configuration.Bind("Local", options.ProviderOptions);
});


builder.Services.AddMudServices();

await builder.Build().RunAsync();
