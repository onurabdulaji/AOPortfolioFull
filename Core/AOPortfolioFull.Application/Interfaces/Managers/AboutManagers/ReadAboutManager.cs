using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutService;
using AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;
using Mapster;

namespace AOPortfolioFull.Application.Interfaces.Managers.AboutManagers;

public class ReadAboutManager : IReadAboutService
{
    private readonly IUnitOfWork _unitOfWork;

    public ReadAboutManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<IList<GetAllAboutDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var allAbout = await _unitOfWork.AboutReadRepository.GetAllAsync(cancellationToken: cancellationToken);
        return allAbout.Adapt<IList<GetAllAboutDto>>();
    }
    public async Task<IList<GetAllAboutDto>> GetAllActiveAsync(bool isActive = true, CancellationToken cancellationToken = default)
    {
        var allAboutActives = await _unitOfWork.AboutReadRepository.GetAllActiveAsync(cancellationToken: cancellationToken);
        return allAboutActives.Adapt<IList<GetAllAboutDto>>();
    }

    public async Task<IList<GetAboutByIdDto>> GetByIdActiveAsync(Guid Id, CancellationToken cancellationToken = default)
    {
        var aboutById = await _unitOfWork.AboutReadRepository.GetByIdActiveAsync(Id, cancellationToken: cancellationToken);
        return new List<GetAboutByIdDto> { aboutById.Adapt<GetAboutByIdDto>() };
    }

    public async Task<IList<GetAboutByIdDto>> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default)
    {
        var aboutById = await _unitOfWork.AboutReadRepository.GetByIdAsync(Id, cancellationToken: cancellationToken);
        return new List<GetAboutByIdDto> { aboutById.Adapt<GetAboutByIdDto>() };
    }
}
