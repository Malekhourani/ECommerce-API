namespace App.Application.DTOs.Common;

public class GetPageWithFilteringDto : GetPageDto
{
    public string FilteringValue { get; init; }
}