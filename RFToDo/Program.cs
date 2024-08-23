using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RFToDo;
using RFToDo.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7214/") });
builder.Services.AddScoped<MetaService>();
builder.Services.AddScoped<TareaService>();

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
