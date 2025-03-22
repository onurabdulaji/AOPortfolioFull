using AOPortfolioFull.Application.DTO.Request.AboutDtos;
using AOPortfolioFull.Application.Interfaces.Services.AboutServices;
using AOPortfolioFull.Application.Validations;
using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;
using Mapster;

namespace AOPortfolioFull.Application.Interfaces.Managers.AboutManagers;

public class WriteAboutManager : IWriteAboutService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IValidatorService _validatorService;

    public WriteAboutManager(IUnitOfWork unitOfWork, IValidatorService validatorService)
    {
        _unitOfWork = unitOfWork;
        _validatorService = validatorService;
    }

    public async Task<CreateAboutDto> CreateAbout(CreateAboutDto createAboutDto)
    {
        await _validatorService.ValidateAsync(createAboutDto);
        
        var newAbout = createAboutDto.Adapt<About>();

        await _unitOfWork.TAboutWriteRepository.CreateAbout(newAbout);
        await _unitOfWork.SaveAsync();

        return newAbout.Adapt<CreateAboutDto>();
    }

    public async Task<UpdateAboutDto> UpdateAbout(UpdateAboutDto updateAboutDto)
    {

        await _validatorService.ValidateAsync(updateAboutDto);

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

    public async Task<ChangeStatusAboutDto> ChangeStatus(Guid Id, CancellationToken token)
    {
        var checkAbout = await _unitOfWork.TAboutReadRepository.GetByIdAsync(Id);
        if(checkAbout is null) throw new Exception($"We can't find about item with this ID => : {Id} .");

        await _unitOfWork.TAboutWriteRepository.ChangeStatus(checkAbout.Id);

        await _unitOfWork.SaveAsync();

        return new ChangeStatusAboutDto { Id = Id, Message = $"Status is changed ! for this ID => : {Id}" };
    }
}

