using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Application.DTOs.Discount;
using App.Application.Services.DiscountActivationServices;
using App.Domain.Models.Discounts;

namespace App.Application.Services.DiscountServices
{
    //TODO: This Service Needs Refactor
    public class DiscountService
    {
        private readonly IDbService _dbService;
        private readonly IAppService _appService;
        private readonly IProductService _productService;
        private readonly IDiscountTypeService _discountTypeService;
        private readonly IDiscountActivationService _discountActivationService;
        private readonly IAuthenticationService _authService;

        public DiscountService(IDbService dbService, IAuthenticationService authService, IAppService appService, IProductService productService, IDiscountTypeService discountTypeService, IDiscountActivationService discountActivationService)
        {
            _dbService = dbService;
            _authService = authService;
            _appService = appService;
            _productService = productService;
            _discountTypeService = discountTypeService;
            _discountActivationService = discountActivationService;
        }

        public async Task CreateDiscount(CreateDiscountDto dto, CancellationToken cancellationToken)
        {
            using var transaction = await _dbService.BeginTransactionAsync();

            var product = await _productService.GetProduct(dto.ProductId, cancellationToken);

            await _discountTypeService.CheckIfDiscountTypeExists(dto.DiscountTypeId, cancellationToken);

            await _discountActivationService.SpecifyDiscountActivationInfo(dto.ActivationInfo, cancellationToken);

            var discount = await _dbService.CreateAsync<Discount, CreateDiscountDto, long>(dto, cancellationToken);

            await transaction.CommitAsync(cancellationToken);
        }

        public Task<IEnumerable<GetDiscountDto>> GetDiscounts(GetPageDto dto, CancellationToken cancellationToken)
        {
            return _dbService.GetAsPageAsync<Discount, long, GetDiscountDto, GetPageDto>(dto, null, cancellationToken);
        }

        public Task DeleteDiscount(Int64 id, CancellationToken cancellationToken)
        {
            return _dbService.DeleteAsync<Discount>(id, cancellationToken);
        }
    }
}
