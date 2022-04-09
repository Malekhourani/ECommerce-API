using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.ActivateCondition
{
    public class UpdateActivateConditionDto
    {
        [Required]
        public short Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
