using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.DTOs.Discount
{
    public class UpdateDiscountDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Value { get; set; }

        public short DiscountTypeId { get; set; }

        public int ProductId { get; set; }
        
        public string ApplicationUserId { get; set; }

        public int ActivateInfoId { get; set; }
    }
}
