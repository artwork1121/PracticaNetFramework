using NF.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Marca Nro.")]
        public long BrandId { get; set; }
        [Display(Name ="Imagen")]
        public Byte[] Image { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(60)]
        [Display(Name = "Nombre")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(100)]
        [Display(Name = "Descripción")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Impuesto")]
        public decimal Tax { get; set; }
        [NotMapped]
        [Display(Name = "Precio Total")]
        public decimal TotalPrice { get => Price * (1 + (Tax / 100)); }
        public virtual IEnumerable<SalesLine> SalesLines { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
    }
}