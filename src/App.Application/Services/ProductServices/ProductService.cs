using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using App.Application.DTOs.Product;
using App.Domain.Models.Products;
using App.Application.Extensions;
using App.Domain.Exceptions.LogicalExceptions.ProductExceptions;
using App.Domain.Models.Users;
using AutoMapper;
using TanvirArjel.EFCore.GenericRepository;
using Microsoft.EntityFrameworkCore;
using App.Domain.Exceptions.TechnicalExceptions;
using Microsoft.AspNetCore.Http;
using App.Application.DTOs.Media;

namespace App.Application.Services.ProductServices
{

    public class ProductService : IProductService
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authService;
        private readonly IRepository _repo;
        private readonly IProductMediaService _productMediaService;

        public ProductService(IDbService dbService,
                              IAuthenticationService authService,
                              IMapper mapper,
                              IRepository repo,
                              IProductMediaService productMediaService)
        {
            _dbService = dbService;
            _authService = authService;
            _mapper = mapper;
            _repo = repo;
            _productMediaService = productMediaService;
        }

        public async Task<uint> CreateProduct(CreateProductDto dto, IFormFile? icon, IEnumerable<IFormFile?>? media, CancellationToken cancellationToken)
        {
            dto.ValidateNewProduct();

            // using var transaction = await _repo.BeginTransactionAsync(cancellationToken: cancellationToken);

            var product = _mapper.Map<CreateProductDto, Product>(dto);

            product.ShopOwnerId = await _authService.GetCurrentUserId(cancellationToken);

            var productId = await _dbService.CreateAsync<Product, uint>(product, cancellationToken);

            if(icon is not null)
                await _productMediaService.AddProductIcon(productId, icon, cancellationToken);

            if(media is not null && media.Any())
                await _productMediaService.AddProductMedia(productId, media, cancellationToken);

            // await transaction.CommitAsync(cancellationToken);

            return productId;
        }

        //TODO: Be Explicit, Create Update Quantity Action Instead Of Updating it From Here.
        public async Task UpdateProduct(UpdateProductDto request, CancellationToken cancellationToken)
        {
            var userId = await _authService.GetCurrentUserId(cancellationToken);

            var product = await _dbService.GetByIdAsync<Product>(request.Id, cancellationToken);

            if (!product.IsTheShopOwner(userId)) throw new OnlyTheShopOwnerCanUpdateProductInfoException();

            // product.ValidateNewProductsQuantity(request.Quantity);

            var newProductInfo = _mapper.Map<UpdateProductDto, Product>(request, product);

            await _dbService.UpdateAsync<Product>(newProductInfo, cancellationToken);
        }

        public async Task DeleteProduct(uint id, CancellationToken cancellationToken)
        {
            var user = await _authService.GetCurrentUser(cancellationToken);

            var product = await _dbService.GetByIdAsync<Product>(id, cancellationToken);

            var isAdmin = await _authService.IsInOneOfRoles(user, Roles.ADMIN_ROLE);

            if (!product.IsAbleToDeleteProduct(user.Id, isAdmin)) throw new OnlyAdminAndTheShopOwnerCanDeleteProductException();

            await _dbService.DeleteAsync<Product>(product, cancellationToken);
        }

        //TODO: this action needs refactor
        public async Task<PageResultDto> GetProducts(GetPageWithFilteringDto dto, CancellationToken cancellationToken)
        {
            // return _dbService.GetAsPageAsync<Product, uint, GetProductPageDto>(dto, cancellationToken);
            // var p = _dbService.GetAsPageAsync<Product, uint, GetProductDto, GetPageWithFilteringDto>(dto, product => product.Name.Contains(dto.FilteringValue) ||
            //                                 product.Price.ToString().Contains(dto.FilteringValue) ||
            //                                 product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()), cancellationToken);

            var products = await _repo.GetQueryable<Product>()
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                            .Include(product => product.Category)
                            .Include(product => product.ShopOwner)
                            // .Skip((dto.PageId - 1) * dto.PageSize)
                            // .Take(dto.PageSize)
                            .Select(product => new GetProductDto()
                            {
                                Id = product.Id,
                                Quantity = product.Quantity,
                                Name = product.Name,
                                Price = product.Price,
                                Description = product.Description,
                                Category = new()
                                {
                                    Id = product.CategoryId,
                                    Name = product.Category.Name
                                },
                                Company = new()
                                {
                                    CompanyId = product.ShopOwnerId,
                                    CompanyName = product.ShopOwner.NormalizedUserName
                                },
                                Media = new List<GetProductMediaInfo>(
                                    product.Media.Where(media => media.IsPrimary)
                                            .Select(media => new GetProductMediaInfo()
                                            {
                                                Id = media.Id,
                                                Endpoint = $"dotnet/Ecommerce/api/media/DownloadMedia/{media.Id}"
                                            }))
                            })
                            .ToListAsync(cancellationToken);

            var productCount = await _repo.GetQueryable<Product>()
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                                            .CountAsync(cancellationToken);


var result = new PageResultDto(){
                Items = products,
                NumberOfItems = productCount
            };

            return result;
        }

        public async Task<PageResultDto> GetProductsByCategory(GetPageByCategoryDto dto, CancellationToken cancellationToken)
        {
            var products = await _repo.GetQueryable<Product>()
                            .Include(product => product.Category)
                            .Include(product => product.ShopOwner)
                            .Where(product => product.CategoryId == dto.CategoryId)
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Category.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                            // .Skip((dto.PageId - 1) * dto.PageSize)
                            // .Take(dto.PageSize)
                            .Select(product => new GetProductDto()
                            {
                                Id = product.Id,
                                Quantity = product.Quantity,
                                Name = product.Name,
                                Price = product.Price,
                                Description = product.Description,
                                Category = new()
                                {
                                    Id = product.CategoryId,
                                    Name = product.Category.Name
                                },
                                Company = new()
                                {
                                    CompanyId = product.ShopOwnerId,
                                    CompanyName = product.ShopOwner.NormalizedUserName
                                },
                                Media = new List<GetProductMediaInfo>(
                                    product.Media.Where(media => media.IsPrimary)
                                            .Select(media => new GetProductMediaInfo()
                                            {
                                                Id = media.Id,
                                                Endpoint = $"dotnet/Ecommerce/api/media/DownloadMedia/{media.Id}"
                                            }))
                            })
                            .ToListAsync(cancellationToken);

            var countOfItems = await _repo.GetQueryable<Product>()
                            .Where(product => product.CategoryId == dto.CategoryId)
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Category.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                                            .CountAsync(cancellationToken);

            var result = new PageResultDto(){
                Items = products,
                NumberOfItems = countOfItems
            };

            // var data = await _mapper.ProjectTo<GetProductDto>(products).ToListAsync(cancellationToken);

            return result;
        }

        public async Task<PageResultDto> GetCurrentCompanyProducts(GetPageWithFilteringDto dto, CancellationToken cancellationToken)
        {
            var currentShopOwnerId = await _authService.GetCurrentUserId(cancellationToken);

            var products = await _repo.GetQueryable<Product>()
                            .Include(product => product.Category)
                            .Include(product => product.Auctions)
                            .Include(product => product.ShopOwner)
                            .Where(product => product.ShopOwnerId == currentShopOwnerId)
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Category.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                            .OrderByDescending(product => product.Id)
                            // .Skip((dto.PageId - 1) * dto.PageSize)
                            // .Take(dto.PageSize)
                            .Select(product => new 
                            {
                                Id = product.Id,
                                Quantity = product.Quantity,
                                Name = product.Name,
                                Price = product.Price,
                                Description = product.Description,
                                Category = new
                                {
                                    Id = product.CategoryId,
                                    Name = product.Category.Name
                                },
                                Company = new
                                {
                                    CompanyId = product.ShopOwnerId,
                                    CompanyName = product.ShopOwner.NormalizedUserName
                                },
                                Media = new List<GetProductMediaInfo>(
                                    product.Media.Where(media => media.IsPrimary)
                                            .Select(media => new GetProductMediaInfo()
                                            {
                                                Id = media.Id,
                                                Endpoint = $"dotnet/Ecommerce/api/media/DownloadMedia/{media.Id}"
                                            })),
                                Auctions = product.Auctions.Select(auction => new 
                                {
                                    Id = auction.Id,
                                    StartDate = auction.StartDate,
                                    EndDate = auction.EndDate,
                                    IsClosed = auction.IsClosed,
                                })
                            })
                            .ToListAsync(cancellationToken);

            var count = await _repo.GetQueryable<Product>()
                            .Where(product => product.ShopOwnerId == currentShopOwnerId)
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Category.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                                            .CountAsync(cancellationToken);

            var result = new PageResultDto()
            {
                Items = products, 
                NumberOfItems = count
            };

            return result;
        }

        public async Task<PageResultDto> GetCompanyProducts(GetPageWithFilteringDto dto, CancellationToken cancellationToken)
        {
            var currentShopOwnerId = await _authService.GetCurrentUserId(cancellationToken);

            var products = await _repo.GetQueryable<Product>()
                            .Include(product => product.Category)
                            .Include(product => product.ShopOwner)
                            .Where(product => product.ShopOwnerId == currentShopOwnerId)
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Category.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                            .OrderByDescending(product => product.Id)
                            // .Skip((dto.PageId - 1) * dto.PageSize)
                            // .Take(dto.PageSize)
                            .Select(product => new GetProductDto()
                            {
                                Id = product.Id,
                                Quantity = product.Quantity,
                                Name = product.Name,
                                Price = product.Price,
                                Description = product.Description,
                                Category = new()
                                {
                                    Id = product.CategoryId,
                                    Name = product.Category.Name
                                },
                                Company = new()
                                {
                                    CompanyId = product.ShopOwnerId,
                                    CompanyName = product.ShopOwner.NormalizedUserName
                                },
                                Media = new List<GetProductMediaInfo>(
                                    product.Media.Where(media => media.IsPrimary)
                                            .Select(media => new GetProductMediaInfo()
                                            {
                                                Id = media.Id,
                                                Endpoint = $"dotnet/Ecommerce/api/media/DownloadMedia/{media.Id}"
                                            }))
                            })
                            .ToListAsync(cancellationToken);

            var count = await _repo.GetQueryable<Product>()
                            .Where(product => product.ShopOwnerId == currentShopOwnerId)
                            .Where(product => product.Name.Contains(dto.FilteringValue) ||
                                            product.Category.Name.Contains(dto.FilteringValue) ||
                                            product.Price.ToString().Contains(dto.FilteringValue) ||
                                            product.ShopOwner.UserName.ToUpper().Contains(dto.FilteringValue.ToUpper()))
                                            .CountAsync(cancellationToken);

            var result = new PageResultDto()
            {
                Items = products, 
                NumberOfItems = count
            };

            return result;
        }


        public async Task<IEnumerable<Product>> GetProducts(IEnumerable<uint> productIds, CancellationToken cancellationToken)
        {
            int requestedProductsCount = productIds.Count();

            // var data = await _repo.GetByRangeAsync<Product, uint>(productIds, cancellationToken);

            var data = await _repo.GetListAsync<Product>(product => productIds.Contains(product.Id));

            if (data.Count != requestedProductsCount) throw new NotAllRequestedProductsWasFoundException();

            return data;
        }

        public async Task<Product> GetProduct(uint id, CancellationToken cancellationToken)
        {
            return await _dbService.GetByIdAsync<Product>(id, cancellationToken);
        }

        public async Task<GetProductDto> GetProductById(uint id, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetQueryable<Product>()
                                    .Where(product => product.Id == id)
                                    .Include(product => product.ShopOwner)
                                    .Include(product => product.Category)
                                    .Include(product => product.Media)
                                    .FirstOrDefaultAsync(cancellationToken);

            if (entity is null) throw new EntityNotFoundException("product not found");
            
            entity.Media = entity.Media.Where(media => !media.IsPrimary).ToList();

            var product = _mapper.Map<Product, GetProductDto>(entity!);

            return product;
        }
    }
}
