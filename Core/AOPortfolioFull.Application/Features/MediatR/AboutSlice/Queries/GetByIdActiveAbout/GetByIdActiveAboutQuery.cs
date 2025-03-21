using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetByIdActiveAbout;

public class GetByIdActiveAboutQuery : IRequest<IList<GetAboutByIdDto>>
{
    public Guid Id { get; set; }
    public GetByIdActiveAboutQuery(Guid id)
    {
        Id = id;
    }
}
