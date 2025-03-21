using AOPortfolioFull.Domain.Interfaces.IBase;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;
using AOPortfolioFull.Persistence.Context.Data;
using Microsoft.EntityFrameworkCore;

namespace AOPortfolioFull.Persistence.Repositories.WriteRepository;

public class WriteRepository<T> : IWriteGenericRepository<T> where T : class, IEntity , new()
{
    protected readonly AppDbContext _context;
    public WriteRepository(AppDbContext context)
    {
        _context = context;
    }
    private DbSet<T> Table { get => _context.Set<T>(); }
    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task AddRangeAsync(IList<T> entities)
    {
        await Table.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }

    public async Task<(bool isSuccess, T entity)> ChangeStatusAsync(T entity)
    {
        entity.IsActive = !entity.IsActive;
        Table.Update(entity);
        var result = await _context.SaveChangesAsync();
        return (result > 0, entity);
    }

    public async Task<T> RemoveAsync(T entity)
    {
        Table.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        Table.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
