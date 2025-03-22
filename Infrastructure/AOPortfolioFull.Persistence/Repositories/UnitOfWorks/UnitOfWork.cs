using AOPortfolioFull.Domain.Interfaces.IBase;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.ReadGeneric;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.ReadRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.WriteRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.ReadRepository;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.WriteRepository;
using AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.WriteRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.ContactRepositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.Concretes.ContactRepositories.WriteRepository;
using AOPortfolioFull.Persistence.Repositories.ReadRepository;
using AOPortfolioFull.Persistence.Repositories.WriteRepository;

namespace AOPortfolioFull.Persistence.Repositories.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{

    private readonly AppDbContext _context;
    private readonly Dictionary<Type, object> _repositories = new(); // (singleton pattern).

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    // Kısıtlamalar arayüzdeki ile aynı olmalı
    public IReadGenericRepository<T> GetReadGenericRepository<T>()
        where T : class, IEntity, new()
    {
        return GetOrCreateRepository<IReadGenericRepository<T>, ReadRepository<T>>();
    }

    public IWriteGenericRepository<T> GetWriteGenericRepository<T>()
       where T : class, IEntity, new()
    {
        return GetOrCreateRepository<IWriteGenericRepository<T>, WriteRepository<T>>();
    }

    public IAboutReadRepository TAboutReadRepository => GetOrCreateRepository<IAboutReadRepository, AboutReadRepository>();
    public IAboutWriteRepository TAboutWriteRepository => GetOrCreateRepository<IAboutWriteRepository, AboutWriteRepository>();
    public IContactReadRepository TContactReadRepository => GetOrCreateRepository<IContactReadRepository, ContactReadRepository>();
    public IContactWriteRepository TContactWriteRepository => GetOrCreateRepository<IContactWriteRepository, ContactWriteRepository>();

    private TRepo GetOrCreateRepository<TInterface, TRepo>() where TRepo : class, TInterface
    {
        if (!_repositories.TryGetValue(typeof(TInterface), out var repo))
        {
            repo = Activator.CreateInstance(typeof(TRepo), _context);
            _repositories[typeof(TInterface)] = repo;
        }
        return (TRepo)repo;
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
        try
        {
            return await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            // Loglama veya hata yönetimi burada yapılabilir.
            Console.WriteLine($"Veritabanı kaydetme hatası: {ex.Message}");
            return -1; // -1, hata durumunu temsil eder.
        }
    }

    public Task<string> SaveAsyncWithMessage()
    {
        throw new NotImplementedException();
    }
}



//IReadGenericRepository<T>, ve IWriteGenericRepository<T> , genel repository arayüzleridir.Bu arayüzler ile, her bir tablo icin tekrardan repository yazmak yerine, generic repositoryler ile her bir tabloya erisim saglanabilir.


//private readonly AppDbContext _context;
//    private readonly Dictionary<Type, object> _repositories = new();

//    public UnitOfWork(AppDbContext appDbContext)
//    {
//        _context = appDbContext;
//    }

//    public IAboutReadRepository TAboutReadRepository
//    {
//        get
//        {
//            if (!_repositories.ContainsKey(typeof(IAboutReadRepository)))
//            {
//                _repositories[typeof(IAboutReadRepository)] = new AboutReadRepository(_context);
//            }
//            return (IAboutReadRepository)_repositories[typeof(IAboutReadRepository)];
//        }
//    }

//    public IAboutWriteRepository TAboutWriteRepository
//    {
//        get
//        {
//            if (!_repositories.ContainsKey(typeof(IAboutWriteRepository)))
//            {
//                _repositories[typeof(IAboutWriteRepository)] = new AboutWriteRepository(_context);
//            }
//            return (IAboutWriteRepository)_repositories[typeof(IAboutWriteRepository)];
//        }
//    }

//    public IContactReadRepository TContactReadRepository
//    {
//        get
//        {
//            if (!_repositories.ContainsKey(typeof(IContactReadRepository)))
//            {
//                _repositories[typeof(IContactReadRepository)] = new ContactReadRepository(_context);
//            }
//            return (IContactReadRepository)_repositories[typeof(IContactReadRepository)];
//        }
//    }

//    public IContactWriteRepository TContactWriteRepository
//    {
//        get
//        {
//            if (!_repositories.ContainsKey(typeof(IContactWriteRepository)))
//            {
//                _repositories[typeof(IContactWriteRepository)] = new ContactWriteRepository(_context);
//            }
//            return (IContactWriteRepository)_repositories[typeof(IContactWriteRepository)];
//        }
//    }

//    public void Dispose()
//    {
//        _context.Dispose();
//    }

//    public ValueTask DisposeAsync()
//    {
//        return _context.DisposeAsync();
//    }

//    public async Task<int> SaveAsync()
//    {
//        return await _context.SaveChangesAsync();
//    }

//    public async Task<string> SaveAsyncWithMessage()
//    {
//        var response = await _context.SaveChangesAsync();
//        return response.ToString();
//    }

//    IReadGenericRepository<T> IUnitOfWork.GetReadGenericRepository<T>()
//    {
//        if (!_repositories.ContainsKey(typeof(IReadGenericRepository<T>)))
//        {
//            _repositories[typeof(IReadGenericRepository<T>)] = new ReadRepository<T>(_context);
//        }
//        return (IReadGenericRepository<T>)_repositories[typeof(IReadGenericRepository<T>)];
//    }

//    IWriteGenericRepository<T> IUnitOfWork.GetWriteGenericRepository<T>()
//    {
//        if (!_repositories.ContainsKey(typeof(IWriteGenericRepository<T>)))
//        {
//            _repositories[typeof(IWriteGenericRepository<T>)] = new WriteRepository<T>(_context);
//        }
//        return (IWriteGenericRepository<T>)_repositories[typeof(IWriteGenericRepository<T>)];
//    }