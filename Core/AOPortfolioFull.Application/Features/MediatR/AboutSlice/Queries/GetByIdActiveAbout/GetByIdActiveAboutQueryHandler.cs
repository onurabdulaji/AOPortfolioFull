using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutService;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetByIdActiveAbout;

public class GetByIdActiveAboutQueryHandler : IRequestHandler<GetByIdActiveAboutQuery, IList<GetAboutByIdDto>>
{
    private readonly IReadAboutService _readAboutService;

    public GetByIdActiveAboutQueryHandler(IReadAboutService readAboutService)
    {
        _readAboutService = readAboutService;
    }

    public async Task<IList<GetAboutByIdDto>> Handle(GetByIdActiveAboutQuery request, CancellationToken cancellationToken)
    {
        var results = await _readAboutService.GetByIdActiveAsync(request.Id, cancellationToken);
        return results ?? new List<GetAboutByIdDto>();
    }
}
