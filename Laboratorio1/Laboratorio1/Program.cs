using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Laboratorio1.Clases;
using Laboratorio1.Interfaces_IoC_DI;

using IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IObra, ObraComedia>();
                    services.AddSingleton<IObra, ObraDrama>();
                    services.AddTransient<IMiembro, MiembroComedia>();
                    services.AddTransient<IMiembro, MiembroDrama>();
                    services.AddScoped<ITeatro, Teatro>();
                    services.AddTransient<ReportServiceLifetime>();
                })
                .Build();

            ExemplifyServiceLifetime(host.Services, "Lifetime 1");
            ExemplifyServiceLifetime(host.Services, "Lifetime 2");
await host.RunAsync();

static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    ReportServiceLifetime logger = provider.GetRequiredService<ReportServiceLifetime>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeLogger>()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<ReportServiceLifetime>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeLogger>()");

    Console.WriteLine();
}