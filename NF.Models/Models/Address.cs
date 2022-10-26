using NF.Models.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class Address : BaseEntity
    {
        [Required]
        [DefaultValue(0)]
        public AddressType type { get; set; } = 0;
        [Required]
        public string Street { get; set; }
        public int StreetNumber { get; set; }
    }
}