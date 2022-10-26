using NF.Models.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(12, ErrorMessage = "El campo no puede tener mas de 12 caracteres.")]
        public string Name { get; set; }
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        [Required]
        public long RolId { get; set; }
    }
}