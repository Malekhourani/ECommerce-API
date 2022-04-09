using App.Application.Contracts;
using App.Application.Contracts.Common;
using App.Application.DTOs.Photo;
using App.Domain.Exceptions.TechnicalExceptions;
using App.Domain.Models.Products.Media;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TanvirArjel.EFCore.GenericRepository;

namespace App.Application.Services.ProdcutMediaServices;

public class ProductMediaService : IProductMediaService
{
    private static readonly string _mediaDirectory = $@"{Directory.GetCurrentDirectory()}\storage\media";

    private readonly IDbService _dbService;
    private readonly IRepository _repository;

    public ProductMediaService(IDbService dbService, IRepository repository)
    {
        _dbService = dbService;
        _repository = repository;
    }

    public async Task MarkMediaAsPrimary(Guid id, CancellationToken cancellationToken)
    {
        var media = await GetMedia(id, cancellationToken);

        var primaryProductMedia = await _dbService.GetAsync<Media>(primaryMedia => primaryMedia.ProductId == media.ProductId && primaryMedia.IsPrimary, cancellationToken);

        media.MarkAsPrimary(primaryProductMedia);

        if (primaryProductMedia is not null)
            await _dbService.UpdateAsync<Media>(primaryProductMedia, cancellationToken);

        await _dbService.UpdateAsync<Media>(media, cancellationToken);
    }

    //TODO: i need to complete this action
    public async Task RemoveMedia(Guid id, CancellationToken cancellationToken)
    {
        var media = await GetMedia(id, cancellationToken);

        var primaryProductMedia = await _dbService.GetAsync<Media>(primaryMedia => primaryMedia.ProductId == media.ProductId && primaryMedia.IsPrimary, cancellationToken);

        await _dbService.DeleteAsync<Media>(media, cancellationToken);

        File.Delete(media.Path);
    }

    
    public Task<Guid> AddProductIcon(uint productId, IFormFile media, CancellationToken cancellationToken)
    {
        return AddMediaToProduct(productId, true, media, cancellationToken);
    }

    public async Task AddProductMedia(uint productId, IEnumerable<IFormFile> media, CancellationToken cancellationToken)
    {
        foreach (var item in media)
        {
            await AddMediaToProduct(productId, false, item, cancellationToken);
        } 
    }

    private async Task<Guid> AddMediaToProduct(uint productId, bool isPrimary, IFormFile file, CancellationToken cancellationToken)
    {
        if (!Directory.Exists(_mediaDirectory)) Directory.CreateDirectory(_mediaDirectory);

        string filePath = $"{_mediaDirectory}\\{Guid.NewGuid()}-{file.FileName}";

        using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            await file.CopyToAsync(stream, cancellationToken);
        }

        var media = Media.Factory(filePath, productId, isPrimary);

        var key = await _dbService.CreateAsync<Media>(media, cancellationToken);

        return (Guid) key[0];
    }

    private async Task<Media> GetMedia(Guid id, CancellationToken cancellationToken)
    {
        var media = await _repository.GetQueryable<Media>()
                                        .Where(media => media.Id == id)
                                        .Include(media => media.Product)
                                        .ThenInclude(product => product.Media)
                                        .FirstOrDefaultAsync(cancellationToken);

        if (media is null) throw new EntityNotFoundException("Media Not Found");

        return media;
    }

    public async Task<string> GetPath(Guid id, CancellationToken cancellationToken)
    {
        var media = await GetMedia(id, cancellationToken);

        return media.Path;
    }
}
