using App.Application.Contracts.Common;
using App.Application.DTOs.ActivationInfo;
using App.Domain.Models.Discounts.DiscountActivationInfo;

namespace App.Application.Services.DiscountActivationServices;

public class DiscountActivationService : IDiscountActivationService
{
    private readonly IDbService _dbService;

    public DiscountActivationService(IDbService dbService)
    {
        _dbService = dbService;
    }

    public async Task SpecifyDiscountActivationInfo(CreateActivationInfoDto dto, CancellationToken cancellationToken)
    {
        var activateInfo = ActivationInfo.Factory(dto.MinValueToActivateDiscount, dto.DiscountId, dto.ActivateConditionId);

        await _dbService.CreateAsync<ActivationInfo>(activateInfo, cancellationToken);
    }
}
