using AOPortfolioFull.Domain.Interfaces.IGenericRepository.ReadGeneric;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;
using AOPortfolioFull.Persistence.Repositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.WriteRepository;
using Microsoft.Extensions.DependencyInjection;

namespace AOPortfolioFull.Persistence.Extensions;

public static class GenericExtensions
{
    public static void AddGenericPatternExtension(this IServiceCollection services)
    {
        services.AddScoped(typeof(IReadGenericRepository<>), typeof(ReadRepository<>));
        services.AddScoped(typeof(IWriteGenericRepository<>), typeof(WriteRepository<>));
    }
}
