using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NF.Models.Models.Base
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [Display(Name = "Eliminado")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
