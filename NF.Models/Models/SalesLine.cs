using NF.Models.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class SalesLine : BaseEntity
    {
        [Required]
        public long ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [NotMapped]
        public decimal Total { get => 0; }
    }
}