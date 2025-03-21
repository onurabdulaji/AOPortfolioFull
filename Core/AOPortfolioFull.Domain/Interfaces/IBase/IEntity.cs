namespace AOPortfolioFull.Domain.Interfaces.IBase;

public interface IEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public bool IsActive { get; set; }
}
