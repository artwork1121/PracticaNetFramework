using NF.Models.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class SalesLine : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Producto Nro.")]
        public long ProductId { get; set; }
        [NotMapped]
        [Display(Name = "Producto")]
        public string ProductName { get => Product.ProductName; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [NotMapped]
        [Display(Name = "Total")]
        public decimal Total => Product.TotalPrice * Quantity;

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}