using NF.Models.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class Company : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MinLength(11)]
        [MaxLength(15)]
        [Display(Name ="C.U.I.T.")]
        public string CUIT { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MinLength(1)]
        [MaxLength(20)]
        [Display(Name = "Nombre")]
        public string CompanyName { get; set; }
    }
}