using NF.Models.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class Product : BaseEntity
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Tax { get; set; }
        [NotMapped]
        public decimal TotalPrice { get => Price * Tax; }
    }
}