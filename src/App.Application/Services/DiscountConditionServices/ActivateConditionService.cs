using System;
using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.DTOs.ActivateCondition;
using App.Application.DTOs.Category;
using App.Application.DTOs.Common;
using App.Domain.Models.Discounts.DiscountActivationInfo.DiscountActivateCondition;

namespace App.Application.Services.DiscountConditionServices
{
    public class ActivateConditionService : IDiscountActivationConditionService
    {
        private readonly IAppService _appService;

        public ActivateConditionService(IAppService appService)
        {
            _appService = appService;
        }

        public async Task<Response> CreateCondition(CreateActivateConditionDto dto, CancellationToken cancellationToken)
        {
            return await _appService.CreateAsync<ActivateCondition, CreateActivateConditionDto, short>(dto, cancellationToken);
        }

        public async Task<Response> UpdateCategory(UpdateActivateConditionDto request, CancellationToken cancellationToken)
        {
            return await _appService.UpdateAsync<ActivateCondition, UpdateActivateConditionDto>(request.Id, request, cancellationToken);
        }

        public async Task<Response> DeleteCategory(short id, CancellationToken cancellationToken)
        {
            return await _appService.DeleteAsync<ActivateCondition>(id, cancellationToken);
        }

        public async Task<Response> GetCategories(CancellationToken cancellationToken)
        {
            return await _appService.GetAllAsync<ActivateCondition, GetProductCategoryDto>(cancellationToken);
        } 
    }
}
