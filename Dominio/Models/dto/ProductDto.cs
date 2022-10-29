using NET_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio.Models.dto
{
    public class ProductDto
    {
        public long Id { get; set; }
        public long BrandId { get; set; }
        public string BrandName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalPrice { get => Price * (1 + (Tax / 100)); }
        public bool IsDeleted { get; set; }
    }
}
