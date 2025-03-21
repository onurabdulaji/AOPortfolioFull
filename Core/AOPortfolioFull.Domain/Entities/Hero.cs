namespace AOPortfolioFull.Domain.Entities;

public class Hero : BaseEntity
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? SubTitle { get; set; }
    public string? BackgroundImageUrl { get; set; }
    public Hero() { }
    public Hero(string? title, string? subTitle, string? backgroundImageUrl)
    {
        Id = Guid.NewGuid();
        Title = title;
        SubTitle = subTitle;
        BackgroundImageUrl = backgroundImageUrl;
    }
}
