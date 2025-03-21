using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.UpdateAbout;

public class UpdateAboutQueryHandler : IRequestHandler<UpdateAboutQuery, UpdateAboutDto>
{
    private readonly IWriteAboutService _writeAboutService;

    public UpdateAboutQueryHandler(IWriteAboutService writeAboutService)
    {
        _writeAboutService = writeAboutService;
    }

    public async Task<UpdateAboutDto> Handle(UpdateAboutQuery request, CancellationToken cancellationToken)
    {
        var updatedAboutDto = await _writeAboutService.UpdateAbout(request.UpdateAboutDto);
        return updatedAboutDto;
    }
}
