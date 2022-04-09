using System;
using App.Application.DTOs.DiscountType;
using App.Domain.Models.Discounts.DiscountTypes;

namespace App.Application.Contracts
{
    public interface IDiscountTypeService
    {
        Task<short> CreateDiscountType(CreateDiscountTypeDto dto, CancellationToken cancellationToken);
        Task UpdateDiscountType(UpdateDiscountTypeDto request, CancellationToken cancellationToken);
        Task DeleteDiscountType(short id, CancellationToken cancellationToken);
        Task<IEnumerable<GetDiscountTypeDto>> GetDiscountTypes(CancellationToken cancellationToken);
        Task CheckIfDiscountTypeExists(short id, CancellationToken cancellationToken);
    }
}
