using AOPortfolioFull.Application.DTO.Request.ContactDtos;
using AOPortfolioFull.Application.Interfaces.Services.ContactServices;
using AOPortfolioFull.Domain.Interfaces.IUnitOfWorks;
using Mapster;

namespace AOPortfolioFull.Application.Interfaces.Managers.ContactManagers;

public class ReadContactManager(IUnitOfWork _unitOfWork) : IReadContactService
{
    public async Task<IList<GetAllContactDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        var allContactResult = await _unitOfWork.TContactReadRepository.GetAllAsync();
        if (allContactResult is null) throw new Exception($"Result list is empty !");
        return allContactResult.Adapt<IList<GetAllContactDto>>();
    }
    public async Task<IList<GetAllContactDto>> GetAllActiveAsync(CancellationToken cancellationToken)
    {
        var allActiveContactResult = await _unitOfWork.TContactReadRepository.GetAllActiveAsync(cancellationToken: cancellationToken);
        cancellationToken.ThrowIfCancellationRequested(); // Repository'den yanıt alındıktan sonra iptal kontrolü
        return allActiveContactResult.Adapt<IList<GetAllContactDto>>();
    }
}


//cancellationToken.ThrowIfCancellationRequested() // Bu async methodlarda cancel yapmak icin kullanilir , var em CancellationTokenSource ne ayarlanabiler. Genellikle islemler arasi vermek zarar getirmez