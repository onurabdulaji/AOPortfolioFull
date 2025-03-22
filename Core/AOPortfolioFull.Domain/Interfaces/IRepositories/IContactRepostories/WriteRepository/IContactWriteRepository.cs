using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IGenericRepository.WriteGeneric;

namespace AOPortfolioFull.Domain.Interfaces.IRepositories.IContactRepostories.WriteRepository;

public interface IContactWriteRepository : IWriteGenericRepository<Contact>
{
    Task<Contact> CreateAsync(Contact createContact);
    Task<Contact> UpdateAsync(Contact updateContact);
    Task<Contact> DeleteAsync(Guid Id);
    Task<Contact> ChangeStatus(Guid Id);
}