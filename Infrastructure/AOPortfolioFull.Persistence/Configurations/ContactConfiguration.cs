using AOPortfolioFull.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AOPortfolioFull.Persistence.Configurations;

public class ContactConfiguration : BaseConfiguration<Contact>
{
    public override void Configure(EntityTypeBuilder<Contact> builder)
    {
        base.Configure(builder);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Address)
            .IsRequired();

        builder.Property(x => x.Phone)
            .IsRequired();

        builder.Property(x => x.Email)
            .IsRequired();

        builder.Property(x => x.Map)
            .IsRequired();
    }
}
