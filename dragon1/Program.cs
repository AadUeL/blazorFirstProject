using dragon1;
using dragon1.ApiRequests;
using dragon1.ApiRequests.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ApiRequest>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7216") });
builder.Services.AddSingleton<UserService>();

await builder.Build().RunAsync();
