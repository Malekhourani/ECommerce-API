using App.Application.DTOs.Common;

namespace App.Application.DTOs.Product;

public class GetPageByCategoryDto : GetPageWithFilteringDto
{
    public short CategoryId { get; set; }
}
