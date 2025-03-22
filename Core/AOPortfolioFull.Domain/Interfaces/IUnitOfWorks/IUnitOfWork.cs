using AOPortfolioFull.Domain.Interfaces.IBase;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.ReadGeneric;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.ReadRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.WriteRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.ReadRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.WriteRepository;

namespace AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    IReadGenericRepository<T> GetReadGenericRepository<T>() where T : class, IEntity, new();
    IWriteGenericRepository<T> GetWriteGenericRepository<T>() where T : class, IEntity, new();
    Task<int> SaveAsync();
    Task<string> SaveAsyncWithMessage();
    IAboutReadRepository TAboutReadRepository { get; }
    IAboutWriteRepository TAboutWriteRepository { get; }
    IContactReadRepository TContactReadRepository { get; }
    IContactWriteRepository TContactWriteRepository { get; }
}
