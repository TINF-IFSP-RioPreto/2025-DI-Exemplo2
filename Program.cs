using _2025_DI_Exemplo2;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

// Servicos da aplicação
builder.Services.AddSingleton<IProvedorMapa, MapsHere>();
using var host = builder.Build();
MinhaAplicacao(host.Services);
host.Run();
return;

void MinhaAplicacao(IServiceProvider servicos)
{
    var provedorMapas = servicos.GetService(typeof(IProvedorMapa))
        as IProvedorMapa;
    Console.WriteLine(provedorMapas.NomeProvedor);
    Console.WriteLine(provedorMapas.Rota("IFSP", "Casa"));
}
