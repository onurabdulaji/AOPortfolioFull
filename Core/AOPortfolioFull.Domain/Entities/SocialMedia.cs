namespace AOPortfolioFull.Domain.Entities;

public class SocialMedia : BaseEntity
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public SocialMedia()
    {
    }
    public SocialMedia(string title, string icon, string link)
    {
        Id = Guid.NewGuid();
        Title = title;
        Icon = icon;
        Link = link;
    }
}
