using AOPortfolioFull.Domain.Interfaces.IGenericRepository.ReadGeneric;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.ReadRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.WriteRepository;
using AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.WriteRepository;
using AOPortfolioFull.Persistence.Repositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.WriteRepository;

namespace AOPortfolioFull.Persistence.Repositories.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private readonly Dictionary<Type, object> _repositories = new();

    public UnitOfWork(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public IAboutReadRepository AboutReadRepository
    {
        get
        {
            if (!_repositories.ContainsKey(typeof(IAboutReadRepository)))
            {
                _repositories[typeof(IAboutReadRepository)] = new AboutReadRepository(_context);
            }
            return (IAboutReadRepository)_repositories[typeof(IAboutReadRepository)];
        }
    }

    public IAboutWriteRepository AboutWriteRepository
    {
        get
        {
            if (!_repositories.ContainsKey(typeof(IAboutWriteRepository)))
            {
                _repositories[typeof(IAboutWriteRepository)] = new AboutWriteRepository(_context);
            }
            return (IAboutWriteRepository)_repositories[typeof(IAboutWriteRepository)];
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        return _context.DisposeAsync();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<string> SaveAsyncWithMessage()
    {
        var response = await _context.SaveChangesAsync();
        return response.ToString();
    }

    IReadGenericRepository<T> IUnitOfWork.GetReadGenericRepository<T>()
    {
        if (!_repositories.ContainsKey(typeof(IReadGenericRepository<T>)))
        {
            _repositories[typeof(IReadGenericRepository<T>)] = new ReadRepository<T>(_context);
        }
        return (IReadGenericRepository<T>)_repositories[typeof(IReadGenericRepository<T>)];
    }

    IWriteGenericRepository<T> IUnitOfWork.GetWriteGenericRepository<T>()
    {
        if (!_repositories.ContainsKey(typeof(IWriteGenericRepository<T>)))
        {
            _repositories[typeof(IWriteGenericRepository<T>)] = new WriteRepository<T>(_context);
        }
        return (IWriteGenericRepository<T>)_repositories[typeof(IWriteGenericRepository<T>)];
    }
}
