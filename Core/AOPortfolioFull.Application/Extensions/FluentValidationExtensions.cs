using AOPortfolioFull.Application.Behaviours;
using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Validations;
using AOPortfolioFull.Application.Validations.AboutValidation;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AOPortfolioFull.Application.Extensions;

public static class FluentValidationExtensions
{
    public static void AddFluentValidationExtension(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        services.AddScoped<IValidatorService, ValidatorService>();

        services.AddScoped<IValidator<CreateAboutDto>, CreateAboutValidator>();
        services.AddScoped<IValidator<UpdateAboutDto>, UpdateAboutValidator>();

    }
}