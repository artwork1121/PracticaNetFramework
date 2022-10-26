using NF.Models.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class Company : BaseEntity
    {
        [Required]
        public string CUIT { get; set; }
        [Required]
        public long AddressId { get; set; }
    }
}