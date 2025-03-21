using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.UpdateAbout;

public class UpdateAboutQuery : IRequest<UpdateAboutDto>
{
    public UpdateAboutDto UpdateAboutDto { get; init; }

    public UpdateAboutQuery(UpdateAboutDto updateAboutDto)
    {
        UpdateAboutDto = updateAboutDto ?? throw new ArgumentNullException(nameof(updateAboutDto));
    }
}
