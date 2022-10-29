using System;
using System.Web;

namespace Dominio.Models.dto
{
    public class ProductDto
    {
        public long Id { get; set; }
        public long BrandId { get; set; }
        public HttpPostedFileBase photo { get; set; }
        public Byte[] Image { get; set; }
        public string BrandName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalPrice { get => Price * (1 + (Tax / 100)); }
        public bool IsDeleted { get; set; }
    }
}
