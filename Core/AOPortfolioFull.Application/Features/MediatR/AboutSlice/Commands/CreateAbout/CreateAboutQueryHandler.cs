using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.CreateAbout;

public class CreateAboutQueryHandler : IRequestHandler<CreateAboutQuery, CreateAboutDto>
{
    private readonly IWriteAboutService _writeAboutService;

    public CreateAboutQueryHandler(IWriteAboutService writeAboutService)
    {
        _writeAboutService = writeAboutService;
    }

    public async Task<CreateAboutDto> Handle(CreateAboutQuery request, CancellationToken cancellationToken)
    {
        var createdAboutDto = await _writeAboutService.CreateAbout(request.CreateAboutDto);
        return createdAboutDto;
    }
}
