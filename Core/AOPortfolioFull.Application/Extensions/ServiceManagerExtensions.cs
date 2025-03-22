using AOPortfolioFull.Application.Interfaces.Managers.AboutManagers;
using AOPortfolioFull.Application.Interfaces.Services.AboutService;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using Microsoft.Extensions.DependencyInjection;

namespace AOPortfolioFull.Application.Extensions;

public static class ServiceManagerExtensions
{
    public static void AddServiceAndManagersExtensions(this IServiceCollection services)
    {
        services.AddScoped<IReadAboutService, ReadAboutManager>();
        services.AddScoped<IWriteAboutService, WriteAboutManager>();

    }
}
