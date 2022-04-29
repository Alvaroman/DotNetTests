using Course_Project;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddScoped<IMyTest, MyTest>())
    .Build();

ExemplifyScoping(host.Services, "Scope 1");

await host.RunAsync();

static void ExemplifyScoping(IServiceProvider services, string scope)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    IMyTest logger = provider.GetRequiredService<IMyTest>();
    
    Console.WriteLine($"The number is {logger.GetNumber()}");
    Console.WriteLine($"The number one is {logger.GetNumberOne()}");
           
}