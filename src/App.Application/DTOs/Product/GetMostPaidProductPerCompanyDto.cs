namespace App.Application.DTOs.Product;

public class GetMostPaidProductPerCompanyDto
{
    public Guid CompanyId { get; init; }
    public string Company { get; init; }
    public IEnumerable<GetMostPaidProductDto> Products { get; init; }
}
