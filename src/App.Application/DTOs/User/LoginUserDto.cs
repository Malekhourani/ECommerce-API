using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.User
{
    public class LoginUserDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
