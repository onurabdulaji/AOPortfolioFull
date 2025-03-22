using AOPortfolioFull.Application.Mapster;
using AOPortfolioFull.Domain.Entities;

namespace AOPortfolioFull.Application.DTO.Request.AboutDtos;

public class ChangeStatusAboutDto : BaseDTOConfiguration<GetAboutByIdDto, About>
{
    public Guid Id { get; set; }
    public string Message { get; set; }
}
