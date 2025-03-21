using AOPortfolioFull.Domain.Interfaces.IBase;

namespace AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;

public interface IWriteGenericRepository<T> where T : class, IEntity, new()
{
    Task AddAsync(T entity);
    Task AddRangeAsync(IList<T> entities);
    Task<T> UpdateAsync(T entity);
    Task<T> RemoveAsync(T entity);
    Task<(bool isSuccess, T entity)> ChangeStatusAsync(T entity);
}
