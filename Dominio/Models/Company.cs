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
        public string CUIT { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(20)]
        [Display(Name = "Nombre")]
        private string CompanyName { get; set; }
    }
}