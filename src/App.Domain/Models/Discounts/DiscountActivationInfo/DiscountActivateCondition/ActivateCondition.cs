using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Models.Discounts.DiscountActivationInfo.DiscountActivateCondition
{
    public class ActivateCondition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }
        [MaxLength(25)]
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
