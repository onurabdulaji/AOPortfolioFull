using AOPortfolioFull.Application.DTO.Request.ContactDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.ContactSlice.Queries.GetAllContact;

public class GetAllContactQuery : IRequest<IList<GetAllContactDto>>
{
}
