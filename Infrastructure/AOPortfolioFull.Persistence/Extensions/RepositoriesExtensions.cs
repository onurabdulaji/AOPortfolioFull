using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.ReadRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.WriteRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.ReadRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.WriteRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.WriteRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.ContactRepositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.ContactRepositories.WriteRepository;
using Microsoft.Extensions.DependencyInjection;

namespace AOPortfolioFull.Persistence.Extensions;

public static class RepositoriesExtensions
{
    public static void AddRepositoriesExtension(this IServiceCollection services)
    {
        services.AddScoped<IAboutReadRepository, AboutReadRepository>();
        services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();

        services.AddScoped<IContactReadRepository, ContactReadRepository>();
        services.AddScoped<IContactWriteRepository, ContactWriteRepository>();
    }
}
