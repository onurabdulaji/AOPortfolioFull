using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.ReadRepository;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.ReadRepository;
using Microsoft.EntityFrameworkCore;

namespace AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.ReadRepository;

public class AboutReadRepository : ReadRepository<About>, IAboutReadRepository
{
    public AboutReadRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<IList<About>> GetAllAsync(bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (!trackChanges) { query = query.AsNoTracking(); }
        return await query.ToListAsync(cancellationToken);

    }

    public async Task<IList<About>> GetAllActiveAsync(bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (isActive) { query = query.Where(a => a.IsActive); }
        if (!trackChanges) { query = query.AsNoTracking(); }
        return await query.ToListAsync(cancellationToken);
    }

    public async Task<About> GetByIdActiveAsync(Guid id, bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (isActive) { query = query.Where(a => a.IsActive); }
        if (!trackChanges) { query = query.AsNoTracking(); }

        return await query.FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
    }

    public async Task<About> GetByIdAsync(Guid id, bool trackChanges = false, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (!trackChanges) { query = query.AsNoTracking(); }

        return await query.FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
    }
}
