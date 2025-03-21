using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutService;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAboutById;

public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, IList<GetAboutByIdDto>>
{
    private readonly IReadAboutService _readAboutService;

    public GetAboutByIdQueryHandler(IReadAboutService readAboutService)
    {
        _readAboutService = readAboutService;
    }

    public Task<IList<GetAboutByIdDto>> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
    {
        var result = _readAboutService.GetByIdAsync(request.Id, cancellationToken);
        return result ?? throw new Exception("Listede hata donmekte , kontrol edin");
    }
}
