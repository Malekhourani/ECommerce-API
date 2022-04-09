using System.ComponentModel.DataAnnotations;
using App.Application.DTOs.ActivationInfo;

namespace App.Application.DTOs.Discount
{
    public class CreateDiscountDto
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public short DiscountTypeId { get; set; }

        [Required]
        public uint ProductId { get; set; }

        [Required]
        public CreateActivationInfoDto ActivationInfo { get; set; }
    }
}
