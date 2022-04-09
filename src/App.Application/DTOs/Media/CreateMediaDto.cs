using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace App.Application.DTOs.Media;

public class CreateMediaDto
{
    [Required]
    public bool IsPrimary { get; init; } 
    
    public IFormFile Media { get; init; }
}