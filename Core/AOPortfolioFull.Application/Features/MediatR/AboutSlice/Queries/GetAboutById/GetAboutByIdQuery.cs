using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAboutById;

public class GetAboutByIdQuery : IRequest<IList<GetAboutByIdDto>>
{
    public Guid Id { get; set; }
    public GetAboutByIdQuery(Guid id)
    {
        Id = id;
    }
}
