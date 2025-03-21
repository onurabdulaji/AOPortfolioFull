using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.WriteRepository;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.WriteRepository;

namespace AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.WriteRepository;

public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
{
    public AboutWriteRepository(AppDbContext context) : base(context)
    {
    }
}
