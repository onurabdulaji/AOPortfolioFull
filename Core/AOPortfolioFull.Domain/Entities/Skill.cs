namespace AOPortfolioFull.Domain.Entities;
public class Skill : BaseEntity
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int? Value { get; set; }
    public Skill()
    {
    }
    public Skill(string title, int value)
    {
        Id = Guid.NewGuid();
        Title = title;
        Value = value;
    }
}