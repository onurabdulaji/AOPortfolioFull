using AOPortfolioFull.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOPortfolioFull.Persistence.Configurations;

public class ServiceConfiguration : BaseConfiguration<Service>
{
    public override void Configure(EntityTypeBuilder<Service> builder)
    {
        base.Configure(builder);
        builder.HasKey(x => x.Id);
    }
}
