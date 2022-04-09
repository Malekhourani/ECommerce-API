using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.User;

public class CreateDriverDto : CreateUserDto
{
    [Required]
    [Phone]
    public string PhoneNumber { get; set; }
}
