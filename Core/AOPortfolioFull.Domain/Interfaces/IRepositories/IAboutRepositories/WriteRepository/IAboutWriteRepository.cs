using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;

namespace AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.WriteRepository;

public interface IAboutWriteRepository : IWriteGenericRepository<About>
{
    Task<About> CreateAbout(About createAbout);
    Task<About> UpdateAbout(About updateAbout);
    Task<About> DeleteAbout(Guid Id);
    Task<About> ChangeStatus(Guid Id);
}
