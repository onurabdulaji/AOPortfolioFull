using AOPortfolioFull.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOPortfolioFull.Persistence.Configurations;
public class EducationConfiguration : BaseConfiguration<Education>
{
    public override void Configure(EntityTypeBuilder<Education> builder)
    {
        base.Configure(builder);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FromYear)
            .IsRequired();

        builder.Property(x => x.ToYear)
           .IsRequired();

        builder.Property(x => x.Degree)
           .IsRequired();

        builder.Property(x => x.Description)
           .IsRequired();
    }
}
