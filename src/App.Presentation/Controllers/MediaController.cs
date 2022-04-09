using App.Application.Contracts;
using App.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace App.Presentation.Controllers;

public class MediaController : BaseController<IProductMediaService>
{
    public MediaController(IProductMediaService service) : base(service)
    {
    }

    [HttpPost]
    public async Task<Guid> AddProductIcon([FromRoute] uint productId, [FromForm] IFormFile file, CancellationToken cancellationToken)
    {
        return await _service.AddProductIcon(productId, file, cancellationToken);
    }

    [HttpPost]
    public async Task AddProductMedia([FromRoute] uint productId, [FromForm] IEnumerable<IFormFile> files, CancellationToken cancellationToken)
    {
        await _service.AddProductMedia(productId, files, cancellationToken);
    }

    [HttpDelete]
    public async Task RemoveMedia(Guid id, CancellationToken cancellationToken)
    {
        await _service.RemoveMedia(id, cancellationToken);
    }

    // [HttpPatch]
    // public async Task MarkMediaAsPrimary(Guid id, CancellationToken cancellationToken)
    // {
    //     await _service.MarkMediaAsPrimary(id, cancellationToken);
    // }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult> DownloadMedia(Guid id, CancellationToken cancellationToken)
    {
        var path = await _service.GetPath(id, cancellationToken);

        var fileName = id.ToString() + '.' + path.Split('.').Last();

        var provider = new FileExtensionContentTypeProvider();

        var contentType = "application/octet-stream";

        var bytes = await System.IO.File.ReadAllBytesAsync(path);
        return File(bytes, contentType, fileName, true);
    }
}
