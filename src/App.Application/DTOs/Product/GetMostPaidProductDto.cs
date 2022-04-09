namespace App.Application.DTOs.Product;

public class GetMostPaidProductDto
{
    public uint Id { get; init; }
    public string Name { get; init; }
    public uint PaidQuantity { get; init; }
}
