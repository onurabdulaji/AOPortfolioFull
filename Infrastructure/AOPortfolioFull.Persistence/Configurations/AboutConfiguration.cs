using AOPortfolioFull.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOPortfolioFull.Persistence.Configurations;

public class AboutConfiguration : BaseConfiguration<About>
{
    public override void Configure(EntityTypeBuilder<About> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired();

        builder.Property(x => x.Description)
            .IsRequired();

        builder.Property(x => x.Birthday)
            .IsRequired();

        builder.Property(x => x.Age)
            .IsRequired();

        builder.Property(x => x.Website)
            .IsRequired();

        builder.Property(x => x.Degree)
            .IsRequired();

        builder.Property(x => x.Phone)
            .IsRequired();

        builder.Property(x => x.Email)
            .IsRequired();

        builder.Property(x => x.City)
            .IsRequired();

        builder.Property(x => x.IsFreelanceAvailable)
            .IsRequired();
    }
}