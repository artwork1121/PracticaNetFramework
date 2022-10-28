using NF.Models.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class Brand : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(20)]
        [Display(Name = "Marca")]
        public string BrandName { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}