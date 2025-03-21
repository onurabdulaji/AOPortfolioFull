using AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;
using AOPortfolioFull.Persistence.Repositories.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AOPortfolioFull.Persistence.Extensions;

public static class UoWExtensions
{
    public static void AddUnitOfWorkExtension(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
