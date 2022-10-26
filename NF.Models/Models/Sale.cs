using NF.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class Sale : BaseEntity
    {
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int SaleNumber { get; set; }
        public bool IsClosed { get; set; }
        [Required]
        public IEnumerable<SalesLine> SalesLines { get; set; }
        [NotMapped]
        public decimal TotalSale { get => 0; }
    }
}