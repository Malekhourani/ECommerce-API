using App.Application.DTOs.Photo;
using Microsoft.AspNetCore.Http;

namespace App.Application.Contracts;

public interface IProductMediaService
{
    Task<Guid> AddProductIcon(uint productId, IFormFile media, CancellationToken cancellationToken);
    Task AddProductMedia(uint productId, IEnumerable<IFormFile> media, CancellationToken cancellationToken);
    Task RemoveMedia(Guid id, CancellationToken cancellationToken);
    Task MarkMediaAsPrimary(Guid id, CancellationToken cancellationToken);

    Task<string> GetPath(Guid id, CancellationToken cancellationToken);
}
