using App.Application.DTOs.ActivationInfo;

namespace App.Application.Services.DiscountActivationServices;

public interface IDiscountActivationService
{
    Task SpecifyDiscountActivationInfo(CreateActivationInfoDto dto, CancellationToken cancellationToken);
}
