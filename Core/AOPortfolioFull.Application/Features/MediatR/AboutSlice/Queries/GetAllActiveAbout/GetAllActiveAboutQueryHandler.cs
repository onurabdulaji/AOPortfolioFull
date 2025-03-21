using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutService;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllActiveAbout;

public class GetAllActiveAboutQueryHandler : IRequestHandler<GetAllActiveAboutQuery, IList<GetAllAboutDto>>
{
    private readonly IReadAboutService _readAboutService;

    public GetAllActiveAboutQueryHandler(IReadAboutService readAboutService)
    {
        _readAboutService = readAboutService;
    }

    public async Task<IList<GetAllAboutDto>> Handle(GetAllActiveAboutQuery request, CancellationToken cancellationToken)
    {
        var results = await _readAboutService.GetAllActiveAsync();
        return results ?? new List<GetAllAboutDto>();
    }
}
