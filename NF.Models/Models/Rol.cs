using NF.Models.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class Rol : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}