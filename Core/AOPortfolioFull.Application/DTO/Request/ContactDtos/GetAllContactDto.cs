using AOPortfolioFull.Application.Mapster;
using AOPortfolioFull.Domain.Entities;

namespace AOPortfolioFull.Application.DTO.Request.ContactDtos;

public class GetAllContactDto : BaseDTOConfiguration<GetAllContactDto,Contact>
{
    public Guid Id { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Map { get; set; }
}
