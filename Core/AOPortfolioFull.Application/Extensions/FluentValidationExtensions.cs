using AOPortfolioFull.Application.Behaviours;
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
    }
}