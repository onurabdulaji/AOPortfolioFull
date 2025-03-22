using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.StatusAbout;

public class StatusAboutQueryHandler : IRequestHandler<StatusAboutQuery, ChangeStatusAboutDto>
{
    private readonly IWriteAboutService _writeAboutService;

    public StatusAboutQueryHandler(IWriteAboutService writeAboutService)
    {
        _writeAboutService = writeAboutService;
    }

    public async Task<ChangeStatusAboutDto> Handle(StatusAboutQuery request, CancellationToken cancellationToken)
    {
        var result = await _writeAboutService.ChangeStatus(request.Id, cancellationToken);
        return result;
    }
}
