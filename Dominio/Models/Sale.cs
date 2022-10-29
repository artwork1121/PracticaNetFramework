using NF.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NET_Framework.Models
{
    public class Sale : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Fecha de creación")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Comprobante")]
        public int SaleNumber { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DefaultValue(false)]
        [Display(Name = "Compleata")]
        public bool IsClosed { get; set; }
        [NotMapped]
        [Display(Name = "Total")]
        public decimal TotalSale => SalesLines.Select(x => x.Total).Sum();

        public virtual IEnumerable<SalesLine> SalesLines { get; set; }
    }
}