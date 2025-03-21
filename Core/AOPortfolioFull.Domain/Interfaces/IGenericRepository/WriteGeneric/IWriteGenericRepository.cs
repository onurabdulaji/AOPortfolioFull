using AOPortfolioFull.Domain.Interfaces.IBase;

namespace AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;

public interface IWriteGenericRepository<T> where T : class, IEntity, new()
{
    Task AddEntityAsync(T entity);
    Task AddEntitiesRangeAsync(IList<T> entities);
    Task<T> UpdateEntityAsync(T entity);
    Task<T> RemoveEntityAsync(T entity);
    Task<(bool isSuccess, T entity)> ChangeEntityStatusAsync(T entity);
}
