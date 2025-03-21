using AOPortfolioFull.Application.DTO.Request.AboutDtos;

namespace AOPortfolioFull.Application.Interfaces.Services.AboutService;

public interface IReadAboutService
{
    Task<IList<GetAllAboutDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<IList<GetAllAboutDto>> GetAllActiveAsync(bool isActive = true, CancellationToken cancellationToken = default);
    Task<IList<GetAboutByIdDto>> GetByIdActiveAsync(Guid Id, CancellationToken cancellationToken = default);
    Task<IList<GetAboutByIdDto>> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);

}
