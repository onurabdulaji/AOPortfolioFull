using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.CreateAbout;

public class CreateAboutQuery : IRequest<CreateAboutDto>
{
    public CreateAboutDto CreateAboutDto { get; set; }
    public CreateAboutQuery(CreateAboutDto createAboutDto)
    {
        CreateAboutDto = createAboutDto ?? throw new ArgumentNullException(nameof(createAboutDto));
    }
}

