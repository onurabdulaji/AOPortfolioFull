using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.ReadGeneric;

namespace AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.ReadRepository;

public interface IContactReadRepository : IReadGenericRepository<Contact>
{
    Task<IList<Contact>> GetAllAsync(bool trackChanges = false, CancellationToken cancellationToken = default);
    Task<IList<Contact>> GetAllActiveAsync(bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default);
    Task<Contact> GetByIdActiveAsync(Guid id, bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default);
    Task<Contact> GetByIdAsync(Guid id, bool trackChanges = false, CancellationToken cancellationToken = default);
}
