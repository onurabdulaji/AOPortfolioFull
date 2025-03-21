using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Queries.GetAllActiveAbout;

public class GetAllActiveAboutQuery : IRequest<IList<GetAllAboutDto>>
{
}
