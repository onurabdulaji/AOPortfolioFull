
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AOPortfolioFull.Application.Validations;

public class ValidatorService : IValidatorService
{
    private readonly IServiceProvider _serviceProvider;

    public ValidatorService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task ValidateAsync<T>(T dto)
    {
        var validator = _serviceProvider.GetService<IValidator<T>>();
        if (validator == null)
        {
            throw new InvalidOperationException($"No validator found for {typeof(T).Name}");
        }

        var result = await validator.ValidateAsync(dto);
        if (!result.IsValid)
        {
            throw new ValidationException(result.Errors);
        }
    }
}
