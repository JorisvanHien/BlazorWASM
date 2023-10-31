using BlazorTest1;
using BlazorTest1.Service.Bitcoin;
using BlazorTest1.Service.Cat;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<ICatService, CatService>(client =>
{
    client.BaseAddress = new Uri("https://catfact.ninja/");
});

builder.Services.AddHttpClient<IBitcoinService, BitcoinService>(client =>
{
    client.BaseAddress = new Uri("https://api.coindesk.com/");
});

await builder.Build().RunAsync();
