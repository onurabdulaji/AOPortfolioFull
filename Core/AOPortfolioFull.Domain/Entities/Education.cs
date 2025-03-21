namespace AOPortfolioFull.Domain.Entities;

public class Education : BaseEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int? FromYear { get; set; }
    public int? ToYear { get; set; }
    public string? Degree { get; set; }
    public string? Description { get; set; }
    public Education() { }
    public Education(string? name, int? fromYear, int? toYear, string? degree, string? description)
    {
        Id = Guid.NewGuid();
        Name = name;
        FromYear = fromYear;
        ToYear = toYear;
        Degree = degree;
        Description = description;
    }
}
