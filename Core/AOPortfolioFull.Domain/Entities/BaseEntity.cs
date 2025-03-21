using AOPortfolioFull.Domain.Interfaces.IBase;

namespace AOPortfolioFull.Domain.Entities;

public class BaseEntity : IEntity
{
    public BaseEntity()
    {
        CreatedDate = DateTime.UtcNow;
        IsActive = true;
    }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public bool IsActive { get; set; }
}
