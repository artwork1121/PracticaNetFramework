using NF.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Framework.Models
{
    public class Client : BaseEntity
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(20)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(20)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Email { get; set; }
        [Display(Name = "Cumpleaños")]
        public DateTime Birthday { get; set; }
        //public IEnumerable<Address> Address { get; set; }

        //[ForeignKey(AddessId)]
        //[Display(Name = "Dirección")]
        public virtual IEnumerable<Address> Addresses { get; set; }
    }
}