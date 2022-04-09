using System;
using System.ComponentModel.DataAnnotations;
using App.Domain.Models.Discounts.DiscountTypes;
using App.Domain.Models.Products;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Models.Discounts
{
    public class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Value { get; set; }

        public short DiscountTypeId { get; set; }
        public DiscountType DiscountType { get; set; }

        public uint ProductId { get; set; }
        public Product Product { get; set; }

        
    }
}
