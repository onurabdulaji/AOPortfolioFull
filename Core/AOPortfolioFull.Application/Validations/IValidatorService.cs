namespace AOPortfolioFull.Application.Validations;

public interface IValidatorService
{
    Task ValidateAsync<T>(T dto);
}
