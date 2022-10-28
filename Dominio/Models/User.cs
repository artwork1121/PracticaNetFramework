using NF.Models.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(30, ErrorMessage = "El campo no puede tener mas de 30 caracteres.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Fecha de creación")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Estado")]
        public bool IsActive { get; set; } = true;
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public long RolId { get; set; }

        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }
    }
}