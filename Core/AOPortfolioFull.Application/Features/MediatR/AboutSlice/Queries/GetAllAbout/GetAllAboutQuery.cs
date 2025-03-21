using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllAbout;

public class GetAllAboutQuery : IRequest<IList<GetAllAboutDto>>
{
}
