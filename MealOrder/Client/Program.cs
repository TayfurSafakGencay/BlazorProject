using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.Modal;
using MealOrder.Client.Utils;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MealOrder.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("#app");

      builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

      builder.Services.AddScoped<ModalManager>();
      
      builder.Services.AddBlazoredModal();

      await builder.Build().RunAsync();
    }
  }
}