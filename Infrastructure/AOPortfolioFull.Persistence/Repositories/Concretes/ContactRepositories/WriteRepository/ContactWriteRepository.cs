using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.WriteRepository;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.WriteRepository;

namespace AOPortfolioFull.Persistence.Repositories.Concretes.ContactRepositories.WriteRepository;

public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
{
    public ContactWriteRepository(AppDbContext context) : base(context)
    {
    }

    public Task<Contact> ChangeStatus(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> CreateAsync(Contact createContact)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> DeleteAsync(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> UpdateAsync(Contact updateContact)
    {
        throw new NotImplementedException();
    }
}
