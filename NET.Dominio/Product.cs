using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET.Dominio
{
	public class Product : EntityBase
	{
		[Required(ErrorMessage = "Debe ingresar un nombre.")]
		[StringLength(50, MinimumLength = 4, ErrorMessage = "Longitud no valida.")]
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public decimal Tax { get; set; }
		[NotMapped]
		public decimal TotalPrice { get => Price+(Price*Tax)/100; }
		public Guid CompanyId { get; set; }
		public virtual Company Company { get; set; }
	}
}