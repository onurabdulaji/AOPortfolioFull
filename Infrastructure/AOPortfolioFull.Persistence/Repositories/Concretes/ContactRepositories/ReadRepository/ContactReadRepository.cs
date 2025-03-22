using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.ReadRepository;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.ReadRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AOPortfolioFull.Persistence.Repositories.Concretes.ContactRepositories.ReadRepository;

public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
{
    public ContactReadRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<IList<Contact>> GetAllAsync(bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        IQueryable<Contact> query = Table;
        if (!trackChanges) query.AsNoTracking();
        return await query.ToListAsync(cancellationToken);
    }

    public async Task<IList<Contact>> GetAllActiveAsync(bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        IQueryable<Contact> query = Table;
        if (isActive) query.Where(c => c.IsActive);
        if (!trackChanges) query.AsNoTracking();
        return await query.ToListAsync(cancellationToken);
    }

    public async Task<Contact> GetByIdActiveAsync(Guid id, bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        IQueryable<Contact> query = Table;
        if (isActive) query.Where(c => c.IsActive);
        if (!trackChanges) query.AsNoTracking();

        return await query.FirstAsync(a => a.Id == id, cancellationToken);
    }
    public async Task<Contact> GetByIdAsync(Guid id, bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        IQueryable<Contact> query = Table;
        if (!trackChanges) query.AsNoTracking();

        return await query.FirstAsync(a => a.Id == id, cancellationToken);
    }

    public IQueryable<Contact> Find(Expression<Func<Contact, bool>> predicate, bool enableTracking = false)
    {
        if (!enableTracking) Table.AsNoTracking();
        return Table.Where(predicate);
    }

    public IQueryable<Contact> GetAllWithQuareable(bool enabledTracking = false)
    {
        return Table.AsQueryable();
    }
}
