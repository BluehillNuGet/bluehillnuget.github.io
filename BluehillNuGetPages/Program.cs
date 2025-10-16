using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BluehillNuGetPages;

internal static class Program {
    private static Task Main(string[] args) {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(_ => new HttpClient {
            BaseAddress = new(builder.HostEnvironment.BaseAddress)
        });

        return builder.Build().RunAsync();
    }
}
