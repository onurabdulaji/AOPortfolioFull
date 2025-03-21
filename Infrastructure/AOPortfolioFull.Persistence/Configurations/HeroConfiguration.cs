using AOPortfolioFull.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOPortfolioFull.Persistence.Configurations;

public class HeroConfiguration : BaseConfiguration<Hero>
{
    public override void Configure(EntityTypeBuilder<Hero> builder)
    {
        base.Configure(builder);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired();

        builder.Property(x => x.SubTitle)
            .IsRequired();

        builder.Property(x => x.BackgroundImageUrl)
            .IsRequired();
    }
}
