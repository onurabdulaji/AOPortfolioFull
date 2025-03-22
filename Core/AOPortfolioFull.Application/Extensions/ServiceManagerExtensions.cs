using AOPortfolioFull.Application.Interfaces.Managers.AboutManagers;
using AOPortfolioFull.Application.Interfaces.Managers.ContactManagers;
using AOPortfolioFull.Application.Interfaces.Services.AboutService;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using AOPortfolioFull.Application.Interfaces.Services.ContactServices;
using Microsoft.Extensions.DependencyInjection;

namespace AOPortfolioFull.Application.Extensions;

public static class ServiceManagerExtensions
{
    public static void AddServiceAndManagersExtensions(this IServiceCollection services)
    {
        services.AddScoped<IReadAboutService, ReadAboutManager>();
        services.AddScoped<IWriteAboutService, WriteAboutManager>();

        services.AddScoped<IReadContactService, ReadContactManager>();
        services.AddScoped<IWriteContactService, WriteContactManager>();

    }
}
