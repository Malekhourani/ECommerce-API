using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Domain.Models.Common;

namespace App.Domain.Models.Products.Categories
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { get; set; }

        [MaxLength(25)]
        [Required]
        public string Name { get; set; }

        public static Category Factory(short id, string name)
        {
            return new Category
            {
                Id = id,
                Name = name
            };
        }
    }
}
