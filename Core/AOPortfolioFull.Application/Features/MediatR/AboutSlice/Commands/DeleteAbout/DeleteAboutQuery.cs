using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using MediatR;

namespace AOPortfolioFull.Application.Features.MediatR.AboutSlice.Commands.DeleteAbout;

public class DeleteAboutQuery : IRequest<DeleteAboutDto>
{
    public Guid Id { get; set; }
}
