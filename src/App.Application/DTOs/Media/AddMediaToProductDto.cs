using System.ComponentModel.DataAnnotations;
using App.Application.DTOs.Media;

namespace App.Application.DTOs.Photo;

public class AddMediaToProductDto
{
    public IEnumerable<CreateMediaDto> Media { get; set; }
}
