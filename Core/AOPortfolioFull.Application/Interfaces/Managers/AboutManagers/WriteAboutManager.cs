using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;
using FluentValidation;
using Mapster;
using System.Threading;

namespace AOPortfolioFull.Application.Interfaces.Managers.AboutManagers;

public class WriteAboutManager : IWriteAboutService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IValidator<CreateAboutDto> _validator;

    public WriteAboutManager(IUnitOfWork unitOfWork, IValidator<CreateAboutDto> validator)
    {
        _unitOfWork = unitOfWork;
        _validator = validator;
    }

    public async Task<CreateAboutDto> CreateAbout(CreateAboutDto createAboutDto)
    {
        var validationResult = await _validator.ValidateAsync(createAboutDto);
        if (!validationResult.IsValid) throw new ValidationException(validationResult.Errors);

        var newAbout = createAboutDto.Adapt<About>();

        await _unitOfWork.TAboutWriteRepository.CreateAbout(newAbout);
        await _unitOfWork.SaveAsync();

        return newAbout.Adapt<CreateAboutDto>();
    }

    public async Task<UpdateAboutDto> UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        var existingAbout = await _unitOfWork.TAboutReadRepository.GetByIdAsync(updateAboutDto.Id);
        if (existingAbout is null) return null;

        updateAboutDto.Adapt(existingAbout);

        await _unitOfWork.TAboutWriteRepository.UpdateAbout(existingAbout);
        await _unitOfWork.SaveAsync();

        return existingAbout.Adapt<UpdateAboutDto>();

    }

    public async Task<DeleteAboutDto> DeleteAbout(Guid Id , CancellationToken token)
    {
        var checkAbout = await _unitOfWork.TAboutReadRepository.GetByIdAsync(Id);
        if (checkAbout is null) throw new Exception($"We can't find about item with this : {Id} .");

        await _unitOfWork.TAboutWriteRepository.DeleteAbout(Id);
        await _unitOfWork.SaveAsync();

        return new DeleteAboutDto { Id = Id, Message = $"About deleted successfully with ID : {Id}" };
    }
}

