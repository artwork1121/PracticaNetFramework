using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace NET.Dominio
{
	public class Adress : EntityBase
	{
		[Required(ErrorMessage = "Debe ingresar una direccion")]
		public string AdressName { get; set; }
		[Required(ErrorMessage = "Debe ingresar la numeración")]
		public int Number { get; set; }
		public bool IsActive { get; set; } = true;
	}
}