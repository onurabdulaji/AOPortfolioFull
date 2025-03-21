using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutService;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllAbout;

public class GetAllAboutQueryHandler : IRequestHandler<GetAllAboutQuery, IList<GetAllAboutDto>>
{
    private readonly IReadAboutService _readAboutService;

    public GetAllAboutQueryHandler(IReadAboutService readAboutService)
    {
        _readAboutService = readAboutService;
    }

    public async Task<IList<GetAllAboutDto>> Handle(GetAllAboutQuery request, CancellationToken cancellationToken)
    {
        var result = await _readAboutService.GetAllAsync(cancellationToken);
        return result ?? throw new Exception("Handle problem, can't execute List.");
    }
}
