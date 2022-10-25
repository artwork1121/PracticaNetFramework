using System.ComponentModel.DataAnnotations.Schema;

namespace NET.Dominio
{
	public class Sale : EntityBase
	{
		public DateTime CreationDate { get; set; }= DateTime.Now;
		public int SN { get; set; }
		public bool IsClosed { get; set; } = false;
		[NotMapped]
		public decimal Total { get => SaleLine.Sum(x=>x.Total); }
		public ICollection<SaleLine> SaleLine { get; set; }
		public Guid CompanyId { get; set; }
		public virtual Company Company { get; set; }
	}
}