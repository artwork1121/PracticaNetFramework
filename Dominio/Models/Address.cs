using NF.Models.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class Address : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DefaultValue(0)]
        [Display(Name = "Tipo de dirección")]
        public AddressType type { get; set; } = 0;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(60)]
        [Display(Name = "Calle")]
        public string Street { get; set; }
        [Display(Name = "Numero")]
        public int StreetNumber { get; set; }
        [Required]
        [Display( Name = "Usuario Nro.")]
        public long UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}