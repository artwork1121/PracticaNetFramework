using NF.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class Client : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        [Required]
        public IEnumerable<Address> Addresses { get; set; }
    }
}