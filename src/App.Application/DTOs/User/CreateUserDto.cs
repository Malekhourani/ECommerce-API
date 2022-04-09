using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.User
{
    public class CreateUserDto 
    {

        // [DataType(DataType.EmailAddress)]
        // [EmailAddress]
        [Required]
        public string Email { get; set; }

    
        // [DataType(DataType.Password)]
        [Required]
        public string Password { get; init; }

        // [DataType(DataType.Password)]
        [Required]
        public string RePassword { get; set; }
    }
}
