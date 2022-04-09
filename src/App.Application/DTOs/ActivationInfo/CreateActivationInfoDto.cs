using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.ActivationInfo
{
    public class CreateActivationInfoDto
    {
        [Required]
        public int MinValueToActivateDiscount { get; set; }

        [Required]
        public Int64 DiscountId { get; set; }

        [Required]
        public short ActivateConditionId { get; set; }
    }
}
