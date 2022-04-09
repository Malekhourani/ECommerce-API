using System;
using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Application.DTOs.DiscountType;
using App.Domain.Models.Discounts.DiscountTypes;

namespace App.Application.Services.DiscountTypeServices
{
    public class DiscountTypeService : IDiscountTypeService
    {
        private readonly IDbService _dbService;

        public DiscountTypeService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<short> CreateDiscountType(CreateDiscountTypeDto dto, CancellationToken cancellationToken)
        {
            return await _dbService.CreateAsync<DiscountType, CreateDiscountTypeDto, short>(dto, cancellationToken);
        }

        public Task UpdateDiscountType(UpdateDiscountTypeDto request, CancellationToken cancellationToken)
        {
            return _dbService.UpdateAsync<DiscountType, UpdateDiscountTypeDto>(request.Id, request, cancellationToken);
        }

        public Task DeleteDiscountType(short id, CancellationToken cancellationToken)
        {
            return _dbService.DeleteAsync<DiscountType>(id, cancellationToken);
        }

        public Task<IEnumerable<GetDiscountTypeDto>> GetDiscountTypes(CancellationToken cancellationToken)
        {
            return _dbService.GetAllAsync<DiscountType, GetDiscountTypeDto>(cancellationToken);
        }

        public Task CheckIfDiscountTypeExists(short id, CancellationToken cancellationToken)
        {
            return _dbService.GetByIdAsync<DiscountType>(id, cancellationToken);
        }
    }
}
