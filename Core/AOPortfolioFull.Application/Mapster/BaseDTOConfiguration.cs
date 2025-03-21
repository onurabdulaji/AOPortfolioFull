using Mapster;

namespace AOPortfolioFull.Application.Mapster;

public abstract class BaseDTOConfiguration<TDto, TEntity> : IRegister where TDto : class, new() where TEntity : class, new()
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<TDto, TEntity>().TwoWays();
    }
}
