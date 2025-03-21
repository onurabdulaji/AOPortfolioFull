using AOPortfolioFull.Application.Mapster;
using AOPortfolioFull.Domain.Entities;

namespace AOPortfolioFull.Application.DTO.Request.AboutDtos;

public class DeleteAboutDto : BaseDTOConfiguration<DeleteAboutDto,About>
{
    public Guid Id { get; set; }
    public string Message { get; set; }
}
