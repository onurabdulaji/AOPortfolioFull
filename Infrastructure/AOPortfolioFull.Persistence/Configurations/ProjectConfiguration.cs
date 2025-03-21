using AOPortfolioFull.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOPortfolioFull.Persistence.Configurations;

public class ProjectConfiguration : BaseConfiguration<Project>
{
    public override void Configure(EntityTypeBuilder<Project> builder)
    {
        base.Configure(builder);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
           .IsRequired();

        builder.Property(x => x.Description)
             .IsRequired();

        builder.Property(x => x.SmallImage)
             .IsRequired();

        builder.Property(x => x.Category)
             .IsRequired();

        builder.Property(x => x.Client)
             .IsRequired();

        builder.Property(x => x.Link)
             .IsRequired();

        builder.Property(x => x.Date)
             .IsRequired();

        builder.Property(x => x.Images)
            .HasConversion(
                v => string.Join(";", v),   // Listeyi string'e çevir
                v => v.Split(";", StringSplitOptions.RemoveEmptyEntries).ToList() // String'i listeye çevir
            );
    }
}
