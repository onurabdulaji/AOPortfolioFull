using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.ReadRepository;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.ReadRepository;

namespace AOPortfolioFull.Persistence.Repositories.Concretes.ContactRepositories.ReadRepository;

public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
{
    public ContactReadRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public Task<IList<Contact>> GetAllActiveAsync(bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Contact>> GetAllAsync(bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> GetByIdActiveAsync(Guid id, bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> GetByIdAsync(Guid id, bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
