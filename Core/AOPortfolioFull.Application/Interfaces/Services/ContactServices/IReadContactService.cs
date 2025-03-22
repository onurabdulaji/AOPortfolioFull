using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.DTO.Request.ContactDtos;

namespace AOPortfolioFull.Application.Interfaces.Services.ContactServices;

public interface IReadContactService
{
    Task<IList<GetAllContactDto>> GetAllAsync(CancellationToken cancellationToken);
    Task<IList<GetAllContactDto>> GetAllActiveAsync(CancellationToken cancellationToken);
    //Task<IList<GetAboutByIdDto>> GetByIdActiveAsync(Guid Id, CancellationToken cancellationToken = default);
    //Task<IList<GetAboutByIdDto>> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
}
