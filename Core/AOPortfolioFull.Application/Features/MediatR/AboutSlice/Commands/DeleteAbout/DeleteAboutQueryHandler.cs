using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.DeleteAbout;

public class DeleteAboutQueryHandler : IRequestHandler<DeleteAboutQuery, DeleteAboutDto>
{
    private readonly IWriteAboutService _writeAboutService;

    public DeleteAboutQueryHandler(IWriteAboutService writeAboutService)
    {
        _writeAboutService = writeAboutService;
    }

    public async Task<DeleteAboutDto> Handle(DeleteAboutQuery request, CancellationToken cancellationToken)
    {
        var result = await _writeAboutService.DeleteAbout(request.Id , cancellationToken);
        return result;
    }
}
