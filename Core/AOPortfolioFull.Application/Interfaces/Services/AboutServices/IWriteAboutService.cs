using AOPortfolioFull.Application.DTO.Request.AboutDtos;

namespace AOPortfolioFull.Application.Interfaces.Services.AboutServices;

public interface IWriteAboutService
{
    Task<CreateAboutDto> CreateAbout(CreateAboutDto createAboutDto);
    Task<UpdateAboutDto> UpdateAbout(UpdateAboutDto updateAboutDto);
    Task<DeleteAboutDto> DeleteAbout(Guid Id , CancellationToken token);
    //Task<About> ChangeStatus(Guid Id);
}
