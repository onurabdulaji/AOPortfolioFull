using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.StatusAbout;

public class StatusAboutQuery : IRequest<ChangeStatusAboutDto>
{
    public Guid Id { get; set; }
}
