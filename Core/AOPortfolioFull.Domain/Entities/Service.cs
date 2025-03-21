namespace AOPortfolioFull.Domain.Entities;
public class Service : BaseEntity
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public Service()
    {

    }
    public Service(string title, string description, string icon)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        Icon = icon;
    }
}