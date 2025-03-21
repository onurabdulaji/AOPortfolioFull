using AOPortfolioFull.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOPortfolioFull.Persistence.Configurations;
public class StatConfiguration : BaseConfiguration<Stat>
{
    public override void Configure(EntityTypeBuilder<Stat> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
