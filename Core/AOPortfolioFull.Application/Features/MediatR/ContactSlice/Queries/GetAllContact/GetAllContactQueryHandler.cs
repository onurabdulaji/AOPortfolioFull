using AOPortfolioFull.Application.DTO.Request.ContactDtos;
using AOPortfolioFull.Application.Interfaces.Services.ContactServices;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.ContactSlice.Queries.GetAllContact;

public class GetAllContactQueryHandler(IReadContactService _readContactService) : IRequestHandler<GetAllContactQuery, IList<GetAllContactDto>>
{
    public async Task<IList<GetAllContactDto>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
    {
        var result = await _readContactService.GetAllAsync(cancellationToken);
        return result ?? throw new Exception("Handle problem, can't execute List.");
    }
}
