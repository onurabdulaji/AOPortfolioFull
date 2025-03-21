using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.ReadRepository;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.ReadRepository;

namespace AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.ReadRepository;

public class AboutReadRepository : ReadRepository<About>, IAboutReadRepository
{
    public AboutReadRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
