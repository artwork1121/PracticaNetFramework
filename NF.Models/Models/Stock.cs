using NF.Models.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace NET_Framework.Models
{
    public class Stock : BaseEntity
    {
        [Required]
        public int Quantity { get; set; } = 0;
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}