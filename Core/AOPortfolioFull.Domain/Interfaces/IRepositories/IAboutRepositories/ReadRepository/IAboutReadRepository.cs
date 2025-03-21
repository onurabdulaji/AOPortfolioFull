using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.ReadGeneric;

namespace AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.ReadRepository;

public interface IAboutReadRepository : IReadGenericRepository<About>
{
    Task<IList<About>> GetAllAsync(bool trackChanges = false, CancellationToken cancellationToken = default);
    Task<IList<About>> GetAllActiveAsync(bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default);
    Task<About> GetByIdActiveAsync(Guid id, bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default);
    Task<About> GetByIdAsync(Guid id, bool trackChanges = false, CancellationToken cancellationToken = default);
}
