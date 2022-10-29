using NF.Models.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class Rol : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(20)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [MaxLength(20)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
    }
}