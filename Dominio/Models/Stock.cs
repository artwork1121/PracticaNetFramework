using NF.Models.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class Stock : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Producto Nro.")]
        public long ProductId { get; set; }
        [NotMapped]
        [Display(Name = "Producto")]
        public string ProductName { get => Product.ProductName; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; } = 0;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Fecha de creación")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public virtual Product Product { get; set; }
    }
}